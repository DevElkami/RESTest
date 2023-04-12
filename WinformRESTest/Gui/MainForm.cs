using NLog;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System;
using System.Windows.Forms;

namespace WinformRESTest;

public partial class MainForm : MaterialForm
{
    private readonly RESTestCore.RESTestCore restTest = null;

    /// <summary>
    /// Main form constructor
    /// </summary>
    public MainForm(ref RESTestCore.RESTestCore restTest)
    {
        try
        {
            this.restTest = restTest;
            InitializeComponent();

            MaterialSkinManager.Instance.AddFormToManage(this);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_40;

            // Databinding with restTest
            materialTextBoxApiUrl.DataBindings.Add("Text", this.restTest, "Url", false, DataSourceUpdateMode.OnPropertyChanged);
            materialMultiLineTextBoxEditData.DataBindings.Add("Text", this.restTest, "Data", false, DataSourceUpdateMode.OnPropertyChanged);
            materialMultiLineTextBoxEditResponse.DataBindings.Add("Text", this.restTest, "HttpResponse", false, DataSourceUpdateMode.OnPropertyChanged);
            materialMultiLineTextBoxEditContent.DataBindings.Add("Text", this.restTest, "HttpContent", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformRESTest)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            // Load last config
            materialTextBoxApiUrl.Text = Properties.Settings.Default.Url;
            materialMultiLineTextBoxEditData.Text = Properties.Settings.Default.Data;
            materialSwitchJson.Checked = Properties.Settings.Default.Json;
            materialComboBoxMethod.SelectedIndex = Properties.Settings.Default.MethodIndex;
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformRESTest)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }

    private void materialComboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            switch (materialComboBoxMethod.SelectedItem.ToString().ToLower())
            {
                case "get": restTest.Method = RESTestCore.RESTestCore.MethodEnum.Get; materialMultiLineTextBoxEditData.ReadOnly = true; break;
                case "post": restTest.Method = RESTestCore.RESTestCore.MethodEnum.Post; materialMultiLineTextBoxEditData.ReadOnly = false; break;
                case "put": restTest.Method = RESTestCore.RESTestCore.MethodEnum.Put; materialMultiLineTextBoxEditData.ReadOnly = false; break;
                case "delete": restTest.Method = RESTestCore.RESTestCore.MethodEnum.Delete; materialMultiLineTextBoxEditData.ReadOnly = true; break;
            }
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformRESTest)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }

    private void materialButtonTestApi_Click(object sender, EventArgs e)
    {
        try
        {
            restTest.MediaType = materialSwitchJson.Checked ? RESTestCore.RESTestCore.MediaTypeEnum.Json : RESTestCore.RESTestCore.MediaTypeEnum.None;

            materialButtonTest.Enabled = false;
            pictureBoxWait.Visible = true;

            Properties.Settings.Default.Url = materialTextBoxApiUrl.Text;
            Properties.Settings.Default.Data = materialMultiLineTextBoxEditData.Text;
            Properties.Settings.Default.Json = materialSwitchJson.Checked;
            Properties.Settings.Default.MethodIndex = materialComboBoxMethod.SelectedIndex;

            Properties.Settings.Default.Save();

            restTest.Send();
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformRESTest)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
        finally
        {
            materialButtonTest.Enabled = true;
            pictureBoxWait.Visible = false;
        }
    }
}
