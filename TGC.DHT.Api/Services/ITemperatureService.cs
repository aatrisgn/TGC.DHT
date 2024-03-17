using TGC.DHT.Api.Models;

namespace TGC.DHT.Api.Services;

public interface ITemperatureService
{
	Task Create(TemperatureRequest temperatureRequest);
}
