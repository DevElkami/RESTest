using System.ComponentModel;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace RESTestCore;

/// <summary>
/// High level API
/// </summary>
public class RESTestCore : INotifyPropertyChanged
{
    private readonly SynchronizationContext syncContext = null!;

    public RESTestCore()
    {
    }

    public RESTestCore(SynchronizationContext syncContext)
    {
        this.syncContext = syncContext;
    }

    #region Properties
    public String Url { get; set; } = null!;
    public String Data { get; set; } = "";
    public String HttpResponse { get; set; } = null!;
    public String HttpContent { get; set; } = null!;
    public HttpStatusCode HttpCode { get; set; } = HttpStatusCode.Unused;

    public enum MediaTypeEnum
    {
        [Description("")]
        None,

        [Description("application/json")]
        Json
    }
    public MediaTypeEnum MediaType { get; set; } = MediaTypeEnum.None;

    public enum MethodEnum
    {
        [Description("get")]
        Get,

        [Description("post")]
        Post,

        [Description("put")]
        Put,

        [Description("delete")]
        Delete
    }
    public MethodEnum Method { get; set; } = MethodEnum.Get;

    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion

    public async Task SendAsync()
    {
        if (syncContext == null)
            throw new NoNullAllowedException("You must give a context");

        await Task.Factory.StartNew(() => Send());
    }

    public void Send()
    {
        try
        {
            HttpCode = HttpStatusCode.Unused;
            HttpResponse = "";
            HttpContent = "";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HttpResponse"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HttpContent"));

            if (String.IsNullOrEmpty(Url))
                throw new ArgumentNullException(nameof(Url), "You must provide a url");

            HttpClient client = new HttpClient();
            StringContent sc = null!;
            if ((MediaType != MediaTypeEnum.None) && !String.IsNullOrEmpty(Data))
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (!string.IsNullOrEmpty(Data))
                    sc = new StringContent(Data, UnicodeEncoding.UTF8, "application/json");
            }
            else
                sc = new StringContent(Data, UnicodeEncoding.UTF8);

            HttpResponseMessage httpResponseMessage = null!;

            switch (Method)
            {
                case MethodEnum.Get: httpResponseMessage = client.GetAsync(Url).Result; break;
                case MethodEnum.Post: httpResponseMessage = client.PostAsync(Url, sc).Result; break;
                case MethodEnum.Put: httpResponseMessage = client.PutAsync(Url, sc).Result; break;
                case MethodEnum.Delete: httpResponseMessage = client.DeleteAsync(Url).Result; break;
            }

            httpResponseMessage.EnsureSuccessStatusCode();

            HttpCode = httpResponseMessage.StatusCode;
            HttpResponse = httpResponseMessage.ToString();
            HttpContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
        }
        catch (Exception except)
        {
            HttpCode = HttpStatusCode.BadRequest;
            HttpResponse = except.ToString();
            HttpContent = except.Message;
        }
        finally
        {
            if (syncContext != null)
            {
                if (PropertyChanged != null)
                {
                    syncContext.Post(_ => PropertyChanged(this, new PropertyChangedEventArgs("HttpResponse")), null);
                    syncContext.Post(_ => PropertyChanged(this, new PropertyChangedEventArgs("HttpContent")), null);
                }
            }
            else
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HttpResponse"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HttpContent"));
            }
        }
    }
}
