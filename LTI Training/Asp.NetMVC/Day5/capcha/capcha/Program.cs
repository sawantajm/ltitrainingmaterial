using BotDetect.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// configure your application pipeline to use SimpleCaptcha middleware

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSimpleCaptcha(builder.Configuration.GetSection("BotDetect"));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddMemoryCache(); // Adds a default in-memory 
                           // implementation of 
                           // IDistributedCache

// Add framework services.
builder.Services.AddMvc();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
