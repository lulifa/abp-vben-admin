using System.Threading.Tasks;

namespace RuiChen.Abp.Saas.Editions;

public interface IEditionDataSeeder
{
    Task SeedDefaultEditionsAsync();
}
