using Db.DbSettings;
using Db.Interfaces;
using Db.Repositiries;
using Microsoft.EntityFrameworkCore;
using Web.Configurations;
using Web.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAuthentication();

builder.Services.AddScoped<IComplimentsRepository, ComplimentsRepository>();

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

