using Microsoft.EntityFrameworkCore;
using ApplicationProduct.Models;
using ApplicationProduct.Services;
using ApplicationProduct.Repositories;
using ApplicationProduct.Controllers;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbContext"))); ;



builder.Services.AddControllers();

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
