using TGC.AzureTableStorage;

namespace TGC.DHT.Api.Models.Entities;

[TableItem("HumidityReads")]
public class HumidityEntity : AzureTableItem
{
	public float Humidity { get; set; }
	public string Room { get; set; } = "N/A";
}
