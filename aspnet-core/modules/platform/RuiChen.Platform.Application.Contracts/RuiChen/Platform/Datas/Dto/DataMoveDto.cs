using System;
using System.ComponentModel;

namespace RuiChen.Platform.Datas;

public class DataMoveDto
{

    [DisplayName("DisplayName:ParentData")]
    public Guid? ParentId { get; set; }
}
