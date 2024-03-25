using QuestionBank.Application.Helpers.Common;
using Microsoft.AspNetCore.Mvc.Versioning;
using System.Text.Json.Serialization;

namespace QuestionBank.Api.Registrars
{
    public class MvcRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddMvc(setupAction: options =>
            {
                options.Filters.Add(typeof(AuthorizationHandler));
                options.EnableEndpointRouting = false;
            });
            builder.Services.AddControllers(config =>
           {
               config.Filters.Add(typeof(ExceptionHandler));
           })
                .AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            builder.Services.Configure<Settings>(builder.Configuration.GetSection("Settings"));
            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;// response header tells preferable 
                config.ApiVersionReader = new UrlSegmentApiVersionReader();// read version from url
            });
            builder.Services.AddVersionedApiExplorer(config =>
            {
                config.GroupNameFormat = "'v'VVV";
                config.SubstituteApiVersionInUrl = true;

            });

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins( "https://svhqdts01:1118",
                                                          "http://localhost:3000",
                                                          "https://svhqdts01:8212",
                                                          "http://svhqdts01:1040",
                                                          "localhost:3000",
                                                          "*.evisa.gov.et",
                                                          "evisa.gov.et")
                                                          .AllowAnyHeader()
                                                          .AllowAnyMethod()
                                                          .AllowAnyOrigin();
                                  });
            });
            builder.Services.BuildServiceProvider();
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
