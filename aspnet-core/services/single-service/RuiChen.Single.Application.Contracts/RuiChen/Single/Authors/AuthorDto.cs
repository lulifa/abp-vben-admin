﻿using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Single.Authors;
public class AuthorDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public DateTime BirthDate { get; set; }

    public string? ShortBio { get; set; }
}
