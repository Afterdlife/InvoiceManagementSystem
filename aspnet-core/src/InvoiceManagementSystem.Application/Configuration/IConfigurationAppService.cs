using InvoiceManagementSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
