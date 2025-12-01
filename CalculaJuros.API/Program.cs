using CalculaJuros.Application.Services;
using CalculaJuros.Domain.Services;
using CalculaJuros.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI
builder.Services.AddScoped<ICalculoJurosService, CalculoJurosService>();
builder.Services.AddScoped<CalculoJurosAppService>();

var app = builder.Build();

// Swagger sempre disponível em dev
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
