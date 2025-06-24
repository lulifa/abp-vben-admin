﻿using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.OssManagement;

public class GetOssContainersInput : PagedAndSortedResultRequestDto
{
    public string Prefix { get; set; }
    public string Marker { get; set; }
}
