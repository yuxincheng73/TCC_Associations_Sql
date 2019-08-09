using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TCCAssociation.Configuration.Dto;

namespace TCCAssociation.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TCCAssociationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
