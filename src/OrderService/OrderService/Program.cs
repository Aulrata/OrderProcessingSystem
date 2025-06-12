using OrderService.Application.Extensions;
using OrderService.Infrastructure.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();
builder.Services.AddRepositories();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.MapGet("/", () => "Hello World!")
    .WithName("GetHelloWorld");

app.Run();