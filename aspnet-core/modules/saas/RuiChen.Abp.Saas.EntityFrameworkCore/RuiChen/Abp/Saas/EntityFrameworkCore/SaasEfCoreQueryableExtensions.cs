﻿using RuiChen.Abp.Saas.Tenants;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RuiChen.Abp.Saas.EntityFrameworkCore;

public static class SaasEfCoreQueryableExtensions
{
    public static IQueryable<Tenant> IncludeDetails(this IQueryable<Tenant> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            .Include(x => x.ConnectionStrings);
    }
}
