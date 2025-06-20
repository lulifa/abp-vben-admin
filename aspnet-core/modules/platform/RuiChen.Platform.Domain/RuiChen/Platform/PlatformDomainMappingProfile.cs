using AutoMapper;
using RuiChen.Platform.Layouts;
using RuiChen.Platform.Menus;
using RuiChen.Platform.Messages;
using RuiChen.Platform.Packages;

namespace RuiChen.Platform;

public class PlatformDomainMappingProfile : Profile
{
    public PlatformDomainMappingProfile()
    {
        CreateMap<Layout, LayoutEto>();

        CreateMap<Menu, MenuEto>();
        CreateMap<UserMenu, UserMenuEto>();
        CreateMap<RoleMenu, RoleMenuEto>();

        CreateMap<Package, PackageEto>();

        CreateMap<EmailMessage, EmailMessageEto>();
        CreateMap<SmsMessage, SmsMessageEto>();
    }
}
