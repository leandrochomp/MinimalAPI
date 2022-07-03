using Microsoft.OpenApi.Models;
using MinimalAPI.SecrecetSauce;

namespace MinimalAPI.EndpointDefinitions
{
    public class SwaggerEndpointDefinition : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MinimalAPI V1"));
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minimal API", Version = "v1" });
                c.EnableAnnotations();
            });
        }
    }
}
