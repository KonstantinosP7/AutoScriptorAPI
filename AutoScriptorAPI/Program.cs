using AutoPrescriptor.Domain.Models;
using AutoScriptor.Infrastructure.Interface;
using AutoScriptor.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IRequestHandler, RequestHandler>();
builder.Services.AddSingleton<IEoppyEservices, EoppyEservices>();
builder.Services.AddSingleton<IDBHandler, DBHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<CommunicationSettings>(builder.Configuration.GetSection("CommunicationSettings"));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
