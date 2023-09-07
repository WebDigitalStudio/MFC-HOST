using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Mf.Configuration.Dto;

namespace Mf.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MfAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
