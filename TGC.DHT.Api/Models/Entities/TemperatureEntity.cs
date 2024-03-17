using TGC.AzureTableStorage;

namespace TGC.DHT.Api.Models.Entities;

[TableItem("TemperatureReads")]
public class TemperatureEntity : AzureTableItem
{
	public float Temperature { get; set; }
	public string Room { get; set; } = "N/A";
}
