using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using prototipo.caliset.Configuration.Dto;

namespace prototipo.caliset.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : calisetAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
