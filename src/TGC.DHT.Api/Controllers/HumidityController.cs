using Microsoft.AspNetCore.Mvc;
using TGC.DHT.Api.Models;
using TGC.DHT.Api.Services;

namespace TGC.DHT.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HumidityController : ControllerBase
{
	private readonly IHumidityService _humidityService;
	public HumidityController(IHumidityService humidityService)
	{
		_humidityService = humidityService;
	}

	[HttpPost]
	public async Task Create([FromBody] HumidityRequest humidityRequest)
	{
		await _humidityService.Create(humidityRequest);
	}
}
