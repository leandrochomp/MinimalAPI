using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Models;
using MinimalAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.Run();