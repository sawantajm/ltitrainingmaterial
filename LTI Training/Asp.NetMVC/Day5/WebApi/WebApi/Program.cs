using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<NorthwindContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


//Add while with integrating with Angular

builder.Services.AddCors();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
