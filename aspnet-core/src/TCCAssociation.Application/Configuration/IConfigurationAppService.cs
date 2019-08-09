using System.Threading.Tasks;
using TCCAssociation.Configuration.Dto;

namespace TCCAssociation.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
