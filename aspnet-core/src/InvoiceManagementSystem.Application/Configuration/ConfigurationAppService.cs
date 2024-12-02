using Abp.Authorization;
using Abp.Runtime.Session;
using InvoiceManagementSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : InvoiceManagementSystemAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
