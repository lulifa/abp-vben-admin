using AutoMapper;
using RuiChen.Platform.Datas;
using RuiChen.Platform.Feedbacks;
using RuiChen.Platform.Layouts;
using RuiChen.Platform.Menus;
using RuiChen.Platform.Messages;
using RuiChen.Platform.Packages;
using RuiChen.Platform.Portal;

namespace RuiChen.Platform;

public class PlatformApplicationMappingProfile : Profile
{
    public PlatformApplicationMappingProfile()
    {
        CreateMap<PackageBlob, PackageBlobDto>();
        CreateMap<Package, PackageDto>();

        CreateMap<DataItem, DataItemDto>();
        CreateMap<Data, DataDto>();
        CreateMap<Menu, MenuDto>()
            .ForMember(dto => dto.Meta, map => map.MapFrom(src => src.ExtraProperties))
            .ForMember(dto => dto.Startup, map => map.Ignore());
        CreateMap<Layout, LayoutDto>()
            .ForMember(dto => dto.Meta, map => map.MapFrom(src => src.ExtraProperties));
        CreateMap<UserFavoriteMenu, UserFavoriteMenuDto>();

        CreateMap<Feedback, FeedbackDto>();
        CreateMap<FeedbackComment, FeedbackCommentDto>();
        CreateMap<FeedbackAttachment, FeedbackAttachmentDto>();

        CreateMap<EmailMessageAttachment, EmailMessageAttachmentDto>();
        CreateMap<EmailMessageHeader, EmailMessageHeaderDto>();
        CreateMap<EmailMessage, EmailMessageDto>();
        CreateMap<SmsMessage, SmsMessageDto>();

        CreateMap<Enterprise, EnterpriseDto>();
    }
}
