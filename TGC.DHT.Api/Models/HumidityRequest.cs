using TGC.DHT.Api.Models.Entities;

namespace TGC.DHT.Api.Models;

public class HumidityRequest : ReadingRequest
{
	public required float Humidity { get; set; }

	public HumidityEntity ToEntity()
	{
		return new HumidityEntity
		{
			Humidity = Humidity,
			Room = Room
		};
	}
}
