﻿using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Single.Books;
public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}