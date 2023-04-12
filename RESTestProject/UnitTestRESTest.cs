using System.Net;

namespace VaultTestProject;

[TestClass]
public class UnitTestDeployerCore
{
    [TestMethod("Test exception")]
    public void TestMethodException()
    {
        RESTestCore.RESTestCore restTest = new();
        restTest.Send();
        Assert.IsTrue(HttpStatusCode.BadRequest == restTest.HttpCode);
        Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpContent));
        Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
    }

    [TestMethod("Test get")]
    public void TestMethodGet()
    {
        {
            RESTestCore.RESTestCore restTest = new();
            restTest.Method = RESTestCore.RESTestCore.MethodEnum.Get;
            restTest.Url = "https://reqres.in/api/users?page=2";
            restTest.Send();
            Assert.IsTrue(HttpStatusCode.OK == restTest.HttpCode);
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpContent));
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
        }

        {
            RESTestCore.RESTestCore restTest = new();
            restTest.Method = RESTestCore.RESTestCore.MethodEnum.Get;
            restTest.Url = "https://reqres.in/api/users?page=2";
            restTest.MediaType = RESTestCore.RESTestCore.MediaTypeEnum.Json;
            restTest.Send();
            Assert.IsTrue(HttpStatusCode.OK == restTest.HttpCode);
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpContent));
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
        }
    }

    [TestMethod("Test post")]
    public void TestMethodPost()
    {
        {
            RESTestCore.RESTestCore restTest = new();
            restTest.Method = RESTestCore.RESTestCore.MethodEnum.Post;
            restTest.Url = "https://reqres.in/api/register";
            restTest.MediaType = RESTestCore.RESTestCore.MediaTypeEnum.Json;
            restTest.Data = "{\r\n    \"email\": \"eve.holt@reqres.in\",\r\n    \"password\": \"pistol\"\r\n}";
            restTest.Send();
            Assert.IsTrue(HttpStatusCode.OK == restTest.HttpCode);
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpContent));
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
        }

        {
            RESTestCore.RESTestCore restTest = new();
            restTest.Method = RESTestCore.RESTestCore.MethodEnum.Post;
            restTest.Url = "https://reqres.in/api/register";
            restTest.Data = "{\r\n    \"email\": \"eve.holt@reqres.in\",\r\n    \"password\": \"pistol\"\r\n}";
            restTest.Send();
            Assert.IsTrue(HttpStatusCode.BadRequest == restTest.HttpCode);
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpContent));
            Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
        }
    }

    [TestMethod("Test put")]
    public void TestMethodPut()
    {
        RESTestCore.RESTestCore restTest = new();
        restTest.Method = RESTestCore.RESTestCore.MethodEnum.Put;
        restTest.Url = "https://reqres.in/api/users/2";
        restTest.MediaType = RESTestCore.RESTestCore.MediaTypeEnum.Json;
        restTest.Data = "{\r\n    \"name\": \"morpheus\",\r\n    \"job\": \"zion resident\"\r\n}";
        restTest.Send();
        Assert.IsTrue(HttpStatusCode.OK == restTest.HttpCode);
        Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpContent));
        Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
    }

    [TestMethod("Test delete")]
    public void TestMethodDelete()
    {
        RESTestCore.RESTestCore restTest = new();
        restTest.Method = RESTestCore.RESTestCore.MethodEnum.Delete;
        restTest.Url = "https://reqres.in/api/users/2";
        restTest.Send();
        Assert.IsTrue(HttpStatusCode.NoContent == restTest.HttpCode);
        Assert.IsTrue(String.IsNullOrEmpty(restTest.HttpContent));
        Assert.IsTrue(!String.IsNullOrEmpty(restTest.HttpResponse));
    }
}