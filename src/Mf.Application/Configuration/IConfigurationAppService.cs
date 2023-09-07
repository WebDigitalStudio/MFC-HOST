using System.Threading.Tasks;
using Mf.Configuration.Dto;

namespace Mf.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
