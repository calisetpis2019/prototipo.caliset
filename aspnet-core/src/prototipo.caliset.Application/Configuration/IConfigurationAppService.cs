using System.Threading.Tasks;
using prototipo.caliset.Configuration.Dto;

namespace prototipo.caliset.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
