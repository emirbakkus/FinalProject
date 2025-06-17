using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// AOP -- Aspect Oriented Programming
// Autofac, Ninject, StructureMap, Castle Windsor, LightInject, DryInject gibi IoC Container'lar kullanabiliriz.
builder.Services.AddControllers();
builder.Services.AddSingleton<IProductService, ProductManager>(); // ��erisinde data tutmuyorsak singleton kullanabiliriz.
builder.Services.AddSingleton<IProductDal, EfProductDal>();
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
