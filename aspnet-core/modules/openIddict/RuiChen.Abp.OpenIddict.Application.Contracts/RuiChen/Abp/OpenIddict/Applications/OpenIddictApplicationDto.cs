﻿using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace RuiChen.Abp.OpenIddict.Applications;

[Serializable]
public class OpenIddictApplicationDto : ExtensibleAuditedEntityDto<Guid>, IHasConcurrencyStamp
{
    public string ClientId { get; set; }
    public string ClientType { get; set; }
    public string ConsentType { get; set; }
    public string DisplayName { get; set; }
    public Dictionary<string, string> DisplayNames { get; set; } = new Dictionary<string, string>();
    public List<string> Endpoints { get; set; } = new List<string>();
    public List<string> GrantTypes { get; set; } = new List<string>();
    public List<string> ResponseTypes { get; set; } = new List<string>();
    public List<string> Scopes { get; set; } = new List<string>();
    public List<string> PostLogoutRedirectUris { get; set; } = new List<string>();
    public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
    public List<string> RedirectUris { get; set; } = new List<string>();
    public OpenIddictApplicationRequirementsDto Requirements { get; set; } = new OpenIddictApplicationRequirementsDto();
    public OpenIddictApplicationSettingsDto Settings { get; set; } = new OpenIddictApplicationSettingsDto();
    public string ApplicationType { get; set; }
    public string ClientUri { get; set; }
    public string LogoUri { get; set; }
    public string JsonWebKeySet { get; set; }
    public string ConcurrencyStamp { get; set; }
}
