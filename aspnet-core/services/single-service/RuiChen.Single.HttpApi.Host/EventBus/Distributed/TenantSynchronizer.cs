﻿using RuiChen.Abp.Saas.Tenants;
using RuiChen.Single.HttpApi.Host.MultiTenancy;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Uow;

namespace RuiChen.Single.HttpApi.Host
{
    public class TenantSynchronizer : 
        IDistributedEventHandler<EntityCreatedEto<TenantEto>>,
        IDistributedEventHandler<EntityUpdatedEto<TenantEto>>,
        IDistributedEventHandler<EntityDeletedEto<TenantEto>>,
        IDistributedEventHandler<TenantConnectionStringUpdatedEto>,
        ITransientDependency
    {
        protected IDataSeeder DataSeeder { get; }
        protected ITenantConfigurationCache TenantConfigurationCache { get; }

        public TenantSynchronizer(
            IDataSeeder dataSeeder,
            ITenantConfigurationCache tenantConfigurationCache)
        {
            DataSeeder = dataSeeder;
            TenantConfigurationCache = tenantConfigurationCache;
        }

        [UnitOfWork]
        public async virtual Task HandleEventAsync(EntityCreatedEto<TenantEto> eventData)
        {
            await TenantConfigurationCache.RefreshAsync();

            await DataSeeder.SeedAsync(eventData.Entity.Id);
        }

        public async virtual Task HandleEventAsync(EntityUpdatedEto<TenantEto> eventData)
        {
            await TenantConfigurationCache.RefreshAsync();
        }

        public async virtual Task HandleEventAsync(EntityDeletedEto<TenantEto> eventData)
        {
            await TenantConfigurationCache.RefreshAsync();
        }

        public async virtual Task HandleEventAsync(TenantConnectionStringUpdatedEto eventData)
        {
            await TenantConfigurationCache.RefreshAsync();
        }
    }
}
