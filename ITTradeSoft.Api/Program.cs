using ITTradeSoft.Application;
using ITTradeSoft.Application.FileServices;
using ITTradeSoft.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFileService,FileService>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
