using System.Threading.Tasks;
using Abp.Application.Services;
using VU.IMS.Sessions.Dto;

namespace VU.IMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
