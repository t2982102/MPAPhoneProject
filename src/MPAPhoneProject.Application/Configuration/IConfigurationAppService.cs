using System.Threading.Tasks;
using MPAPhoneProject.Configuration.Dto;

namespace MPAPhoneProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
