using Microsoft.OpenApi.Models;

namespace Web.Configurations;

public static class SwaggerConfiguration
{
    public static void Init(WebApplicationBuilder builder)
    {
        OpenApiInfo apiInfo = new()
        {
            Title = "Название нашего апи",
            Version = "v1",
            Contact = new OpenApiContact { Email = "pavel_vilkov17@mail.ru" }
        };

        builder.Services.AddSwaggerGen(so =>
        {
            so.SwaggerDoc("v1", apiInfo);
            so.IncludeXmlComments("doc.xml");
            // TODO: Вынести линк в переменные окружения)
        });
    }
}