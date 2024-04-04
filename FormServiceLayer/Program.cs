using Microsoft.EntityFrameworkCore;
using Form_DAL_Layer;
using Form_DAL_Layer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<FormContext>();
builder.Services.AddTransient<Repository>(
    c => new Repository(c.GetRequiredService<FormContext>())
    {

    });
builder.Services.AddCors(Options =>
{
    Options.AddDefaultPolicy(policy => {
        policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
}
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader());


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
