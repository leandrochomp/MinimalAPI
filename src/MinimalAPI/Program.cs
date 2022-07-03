using MinimalAPI.Models;
using MinimalAPI.SecrecetSauce;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions(typeof(Customer));

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseEndpointDefinitions();

app.Run();