using DonaBookApi.Model;
using DonaBookApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<BookSettings>(
    builder.Configuration.GetSection("BookSettings"));


builder.Services.Configure<LocalizationSettings>(
    builder.Configuration.GetSection("LocalizationSettings"));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
