using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Poc.Api.Configurations
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection ConfigurarSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                var contact = new Contact
                {
                    Name = "Bandas",
                    Url = "https://www.linkedin.com/in/olavo-moncaio/"
                };

                swagger.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Bandas e músicas",
                    Description = "API sobre as melhores bandas",
                    Contact = contact
                });
            });

            return services;
        }

        public static IApplicationBuilder UtilizarConfiguracaoSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bandas e músicas");
            });
            return app;
        }
    }
}
