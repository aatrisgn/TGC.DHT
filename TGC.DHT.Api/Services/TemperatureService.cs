using TGC.AzureTableStorage;
using TGC.DHT.Api.Models;
using TGC.DHT.Api.Models.Entities;

namespace TGC.DHT.Api.Services;

public class TemperatureService : ITemperatureService
{
	private readonly IAzureTableStorageRepository<TemperatureEntity> _storageRepository;
	public TemperatureService(IAzureTableStorageRepository<TemperatureEntity> storageRepository)
	{
		_storageRepository = storageRepository;
	}

	public async Task Create(TemperatureRequest temperatureRequest)
	{
		await _storageRepository.CreateAsync(temperatureRequest.ToEntity());
	}
}
