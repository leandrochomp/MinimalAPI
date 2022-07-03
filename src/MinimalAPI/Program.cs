using MinimalAPI.SecrecetSauce;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions();

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseEndpointDefinitions();

app.Run();