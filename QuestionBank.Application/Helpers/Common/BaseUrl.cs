namespace QuestionBank.Application.Helpers.Common;

public static class BaseUrl
{

    public static string PortalBaseUrl() =>
          string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PORTAL_URL")) ? "https://ecaa-iam.azurewebsites.net/" :
        Environment.GetEnvironmentVariable("PORTAL_URL");

    public static string ClientBaseUrl() =>
             string.IsNullOrEmpty(Environment.GetEnvironmentVariable("CLIENT_URL")) ?
             "http://localhost:3000/" :
               Environment.GetEnvironmentVariable("CLIENT_URL");
}

//string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PORTAL_URL")) ? "https:// dev.iam.ethiopianairlines.com/" :