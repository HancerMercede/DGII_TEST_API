using Contracts;
using DGII_TEST_API.Config;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Custom Services
builder.Services.RegisterConfigurationMappers();
builder.Services.AddTransient<IContributorService, ContributorService>();
builder.Services.AddDbContext<ApplicationDbContext>(opt => 
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("connection"));
});

builder.Services.AddSwaggerGen();

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
