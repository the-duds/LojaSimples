using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace LojaSimples.Modulos
{
    public static class SwaggerExtensions
    {
        public static void UsaSwaggerUi(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API LojaSimples - Eduardo Fernandes");

            });
        }

        public static void ConfiguraSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API de Teste - LojaSimples",
                    Description = "Api responsavel pela avaliação e teste aos recrutadores.",
                    Version = "v1",
                    TermsOfService = new Uri("https://github.com/the-duds")
                });


                var apiPath = Path.Combine(AppContext.BaseDirectory, "LojaSimples.xml");
                var applicationPath = Path.Combine(AppContext.BaseDirectory, "LojaSimples.Application.xml");

                c.IncludeXmlComments(apiPath);
                c.IncludeXmlComments(applicationPath);
            });
        }
    }
}
