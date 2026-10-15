using E_COMMERCE_MANAGEMENT.APPDBCONTEXT;
using E_COMMERCE_MANAGEMENT.MOdels;
using E_COMMERCE_MANAGEMENT.Repos.implemnt;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Appdbcontext>(option=>
option.UseSqlServer(builder.Configuration.GetConnectionString("dbkhaled")));

builder.Services.AddScoped<IUnitOfWork, unitOfWorkrepo>();
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IProduct, ProductRepo>();
builder.Services.AddScoped<IOrder, OrderRepo>();

builder.Services.AddControllers();
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
