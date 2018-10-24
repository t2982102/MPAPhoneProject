using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MPAPhoneProject.Configuration.Dto;

namespace MPAPhoneProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MPAPhoneProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
