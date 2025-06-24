using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace RC.MicroService.Single.EntityFrameworkCore.DataSeeder;

public class SingleDataSeederWorker : BackgroundService
{
    protected IDataSeeder DataSeeder { get; }

    public SingleDataSeederWorker(IDataSeeder dataSeeder)
    {
        DataSeeder = dataSeeder;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await DataSeeder.SeedAsync();
    }
}
