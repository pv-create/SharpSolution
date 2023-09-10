using Db.DbSettings;
using Microsoft.EntityFrameworkCore;
using Web.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAuthentication();

DatabaseCongiguration.Init(builder);

SwaggerConfiguration.Init(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

