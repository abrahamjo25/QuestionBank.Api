using QuestionBank.Api.Options;

namespace QuestionBank.Api.Registrars
{
    public class ApplicationInsightsRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["APPINSIGHTS_CONNECTIONSTRING"]);

        }
    }
}
