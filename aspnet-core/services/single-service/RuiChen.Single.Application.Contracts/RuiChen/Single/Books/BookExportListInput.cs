﻿using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Single.Books;
public class BookExportListInput : LimitedResultRequestDto, ISortedResultRequest
{
    [Required]
    public string FileName { get; set; }
    public string? Filterr { get; set; }
    public string? Sorting {  get; set; }
}
