﻿using Asp.Versioning;
using RuiChen.Abp.Auditing.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace RuiChen.Abp.Auditing.SecurityLogs;

[RemoteService(Name = AuditingRemoteServiceConsts.RemoteServiceName)]
[Area("auditing")]
[ControllerName("security-log")]
[Route($"api/{AuditingRemoteServiceConsts.ModuleName}/security-log")]
[Authorize(AuditingPermissionNames.SecurityLog.Default)]
public class SecurityLogController : AbpControllerBase, ISecurityLogAppService
{
    protected ISecurityLogAppService SecurityLogAppService { get; }

    public SecurityLogController(ISecurityLogAppService securityLogAppService)
    {
        SecurityLogAppService = securityLogAppService;
    }

    [HttpDelete]
    [Route("{id}")]
    [Authorize(AuditingPermissionNames.SecurityLog.Delete)]
    public async virtual Task DeleteAsync(Guid id)
    {
        await SecurityLogAppService.DeleteAsync(id);
    }

    [HttpDelete]
    [Route("bulk")]
    [Authorize(AuditingPermissionNames.SecurityLog.Delete)]
    public async virtual Task DeleteManyAsync([FromBody] SecurityLogDeleteManyInput input)
    {
        await SecurityLogAppService.DeleteManyAsync(input);
    }

    [HttpGet]
    [Route("{id}")]
    public async virtual Task<SecurityLogDto> GetAsync(Guid id)
    {
        return await SecurityLogAppService.GetAsync(id);
    }

    [HttpGet]
    public async virtual Task<PagedResultDto<SecurityLogDto>> GetListAsync(SecurityLogGetByPagedDto input)
    {
        return await SecurityLogAppService.GetListAsync(input);
    }
}
