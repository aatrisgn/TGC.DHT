using Microsoft.AspNetCore.Mvc;
using TGC.DHT.Api.Models;
using TGC.DHT.Api.Services;

namespace TGC.DHT.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TemperatureController : ControllerBase
{
	private readonly ITemperatureService _temperatureService;
	public TemperatureController(ITemperatureService temperatureService)
	{
		_temperatureService = temperatureService;
	}

	[HttpPost]
	public async Task Create([FromBody] TemperatureRequest temperatureRequest)
	{
		await _temperatureService.Create(temperatureRequest);
	}
}
