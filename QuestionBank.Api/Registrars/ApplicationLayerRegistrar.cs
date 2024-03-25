using QuestionBank.Application.Helpers.Options;
using QuestionBank.Application.Services;

namespace QuestionBank.Api.Registrars
{
    public class ApplicationLayerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var jwtSettings = new JwtSettings();
            var jwtSection = builder.Configuration.GetSection(nameof(JwtSettings));
            builder.Services.AddScoped<EmailSenderService>();
            builder.Services.Configure<JwtSettings>(jwtSection);
            builder.Services.AddSession(options =>
            {
                options.IOTimeout = TimeSpan.FromMinutes(10);
            });
            builder.WebHost.UseKestrel(k =>
            {
                k.Limits.MaxRequestHeadersTotalSize = 64 * 1024;
                k.Limits.MaxRequestBufferSize = 64 * 1024;
            });
            builder.Configuration.Bind(nameof(JwtSettings), jwtSettings);
            builder.Services.AddScoped<ITokenhandler, TokenHandlerService>();
            builder.Services.AddScoped<IPassword, PasswordService>();
            builder.Services.AddScoped<IEmailSender, EmailSenderService>();

        }
    }
}
