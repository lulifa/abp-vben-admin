using RuiChen.Platform.Routes;
using Volo.Abp.EventBus;

namespace RuiChen.Platform.Menus;

[EventName("platform.menus.menu")]
public class MenuEto : RouteEto
{
    public string Framework { get; set; }
}
