using System.Threading.Tasks;
using Abp.Application.Services;
using VU.IMS.Authorization.Accounts.Dto;

namespace VU.IMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
