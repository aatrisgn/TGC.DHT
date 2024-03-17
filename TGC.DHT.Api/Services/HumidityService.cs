using TGC.AzureTableStorage;
using TGC.DHT.Api.Models;
using TGC.DHT.Api.Models.Entities;

namespace TGC.DHT.Api.Services;

public class HumidityService : IHumidityService
{
	private readonly IAzureTableStorageRepository<HumidityEntity> _azureTableStorageRepository;
	public HumidityService(IAzureTableStorageRepository<HumidityEntity> azureTableStorageRepository)
	{
		_azureTableStorageRepository = azureTableStorageRepository;
	}

	public async Task Create(HumidityRequest humidityRequest)
	{
		await _azureTableStorageRepository.CreateAsync(humidityRequest.ToEntity());
	}
}
