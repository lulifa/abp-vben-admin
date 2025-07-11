﻿using RuiChen.Abp.LocalizationManagement.Features;
using RuiChen.Abp.LocalizationManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace RuiChen.Abp.LocalizationManagement;

[Authorize(LocalizationManagementPermissions.Text.Default)]
[RequiresPreviewFeatures(LocalizationManagementFeatures.Enable)]
public class TextAppService : LocalizationAppServiceBase, ITextAppService
{
    private readonly ITextRepository _textRepository;
    public TextAppService(ITextRepository repository)
    {
        _textRepository = repository;
    }

    public async virtual Task SetTextAsync(SetTextInput input)
    {
        var text = await _textRepository.GetByCultureKeyAsync(input.ResourceName, input.CultureName, input.Key);
        if (text == null)
        {
            await AuthorizationService.CheckAsync(LocalizationManagementPermissions.Text.Create);

            text = new Text(
                input.ResourceName,
                input.CultureName,
                input.Key,
                input.Value);

            await _textRepository.InsertAsync(text);
        }
        else
        {
            await AuthorizationService.CheckAsync(LocalizationManagementPermissions.Text.Update);

            text.SetValue(input.Value);

            await _textRepository.UpdateAsync(text);
        }

        await CurrentUnitOfWork.SaveChangesAsync();
    }

    [Authorize(LocalizationManagementPermissions.Text.Delete)]
    public async virtual Task RestoreToDefaultAsync(RestoreDefaultTextInput input)
    {
        var text = await _textRepository.GetByCultureKeyAsync(input.ResourceName, input.CultureName, input.Key);
        if (text != null)
        {
            await _textRepository.DeleteAsync(text);

            await CurrentUnitOfWork.SaveChangesAsync();
        }
    }
}
