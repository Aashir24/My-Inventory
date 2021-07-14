using System.Threading.Tasks;
using VU.IMS.Configuration.Dto;

namespace VU.IMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
