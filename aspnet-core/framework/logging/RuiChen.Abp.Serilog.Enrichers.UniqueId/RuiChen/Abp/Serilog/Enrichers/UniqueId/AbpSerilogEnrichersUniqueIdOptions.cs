﻿using RuiChen.Abp.IdGenerator.Snowflake;

namespace RuiChen.Abp.Serilog.Enrichers.UniqueId;

public class AbpSerilogEnrichersUniqueIdOptions
{
    public SnowflakeIdOptions SnowflakeIdOptions { get; set; }
    public AbpSerilogEnrichersUniqueIdOptions()
    {
        SnowflakeIdOptions = new SnowflakeIdOptions();
    }
}
