using Contracts;
using DGII_TEST_API.Config;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(opt=> opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Custom Services
builder.Services.RegisterConfigurationMappers();
builder.Services.AddTransient<IContributorService, ContributorService>();
builder.Services.AddTransient<ICFiscalesService,ComprobantesFiscalesService>();
builder.Services.RegisteringSqlServer(builder.Configuration.GetConnectionString("connection")!);

// Cors
builder.Services.ConfiguredCors();

// Serilog
builder.Host.UseSerilog((ctx, lc) =>
     lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
