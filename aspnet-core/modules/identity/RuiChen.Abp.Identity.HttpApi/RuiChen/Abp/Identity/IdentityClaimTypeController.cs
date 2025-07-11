﻿using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;

namespace RuiChen.Abp.Identity;

[RemoteService(true, Name = IdentityRemoteServiceConsts.RemoteServiceName)]
[Area("identity")]
[ControllerName("ClaimType")]
[Route("api/identity/claim-types")]
[Authorize(IdentityPermissions.IdentityClaimType.Default)]
public class IdentityClaimTypeController : AbpControllerBase, IIdentityClaimTypeAppService
{
    protected IIdentityClaimTypeAppService IdentityClaimTypeAppService { get; }
    public IdentityClaimTypeController(IIdentityClaimTypeAppService identityClaimTypeAppService)
    {
        IdentityClaimTypeAppService = identityClaimTypeAppService;
    }

    [HttpPost]
    [Authorize(IdentityPermissions.IdentityClaimType.Create)]
    public async virtual Task<IdentityClaimTypeDto> CreateAsync(IdentityClaimTypeCreateDto input)
    {
        return await IdentityClaimTypeAppService.CreateAsync(input);
    }

    [HttpDelete]
    [Route("{id}")]
    [Authorize(IdentityPermissions.IdentityClaimType.Delete)]
    public async virtual Task DeleteAsync(Guid id)
    {
        await IdentityClaimTypeAppService.DeleteAsync(id);
    }

    [HttpGet]
    [Route("actived-list")]
    public async virtual Task<ListResultDto<IdentityClaimTypeDto>> GetAllListAsync()
    {
        return await IdentityClaimTypeAppService.GetAllListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async virtual Task<IdentityClaimTypeDto> GetAsync(Guid id)
    {
        return await IdentityClaimTypeAppService.GetAsync(id);
    }

    [HttpGet]
    public async virtual Task<PagedResultDto<IdentityClaimTypeDto>> GetListAsync(IdentityClaimTypeGetByPagedDto input)
    {
        return await IdentityClaimTypeAppService.GetListAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    [Authorize(IdentityPermissions.IdentityClaimType.Update)]
    public async virtual Task<IdentityClaimTypeDto> UpdateAsync(Guid id, IdentityClaimTypeUpdateDto input)
    {
        return await IdentityClaimTypeAppService.UpdateAsync(id, input);
    }
}
