﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace RuiChen.Abp.LocalizationManagement
{
    public interface ITextRepository : IRepository<Text, int>
    {
        Task<List<string>> GetExistsKeysAsync(
            string resourceName,
            string cultureName,
            IEnumerable<string> keys,
            CancellationToken cancellationToken = default);

        Task<Text> GetByCultureKeyAsync(
            string resourceName,
            string cultureName,
            string key,
            CancellationToken cancellationToken = default
            );

        [Obsolete("Use GetListAsync")]
        List<Text> GetList(
            string resourceName = null,
            string cultureName = null);

        Task<List<Text>> GetListAsync(
            string resourceName = null,
            string cultureName = null,
            CancellationToken cancellationToken = default);
    }
}
