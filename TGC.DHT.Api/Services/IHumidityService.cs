using TGC.DHT.Api.Models;

namespace TGC.DHT.Api.Services;

public interface IHumidityService
{
	Task Create(HumidityRequest humidityRequest);
}
