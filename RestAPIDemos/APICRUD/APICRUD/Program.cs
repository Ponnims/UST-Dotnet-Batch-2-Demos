using APICRUD.Models;
using APICRUD.Repository;
using APICRUD.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<TraineeDBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Mycon")));
builder.Services.AddScoped<ITraineeRepository, TraineeRepository>();
builder.Services.AddScoped<ITraineeService, TraineeService>();
builder.Services.AddCors(op =>
{
    op.AddPolicy("AllowReactApp", policy =>
 {
     policy.AllowAnyOrigin() // Allow requests from any origin (you can specify the React app's URL if needed)
            .AllowAnyMethod()
            .AllowAnyHeader();
 });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseCors("AllowReactApp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
