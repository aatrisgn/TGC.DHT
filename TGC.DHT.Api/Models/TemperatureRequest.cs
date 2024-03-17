using TGC.DHT.Api.Models.Entities;

namespace TGC.DHT.Api.Models;
public class TemperatureRequest : ReadingRequest
{
	public required float Temperature { get; set; }

	internal TemperatureEntity ToEntity()
	{
		return new TemperatureEntity { Temperature = Temperature, Room = Room };
	}
}
