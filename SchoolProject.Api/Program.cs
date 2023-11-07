using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrustructure;
using SchoolProject.Service;
using SchoolProject.Infrustructure.Data;
using System;


var builder = WebApplication.CreateBuilder(args);

//Connection SQL
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});



//Extention Methods (Repos) Dependancy Injections
builder.Services.InfrustractureDependencies()
    .ServiceDependencies();

// Add services to the container.
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
