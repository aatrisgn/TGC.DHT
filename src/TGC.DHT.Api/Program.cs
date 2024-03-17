using TGC.AzureTableStorage.IoC;
using TGC.DHT.Api.Services;

#pragma warning disable format
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddAzureTableStorage(options =>
{
	options.AccountConnectionString = builder.Configuration.GetValue<string>("Azure:TableStorage:ConnectionString");
});

builder.Services.AddScoped<IHumidityService, HumidityService>();
builder.Services.AddScoped<ITemperatureService, TemperatureService>();

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
#pragma warning restore format
