using CountriesRESTAPI.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddHttpClient<ICountriesApi>((serviceProvider, client) =>
{
    //client.BaseAddress = new Uri("https://restcountries.com/v3.1/all");
});
builder.Services.AddScoped<ICountriesApi, CountriesApi>();
builder.Services.AddScoped<IDataFilesGenerator, DataFilesGenerator>();
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
