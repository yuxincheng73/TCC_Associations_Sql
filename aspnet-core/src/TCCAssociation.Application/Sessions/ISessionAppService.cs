using System.Threading.Tasks;
using Abp.Application.Services;
using TCCAssociation.Sessions.Dto;

namespace TCCAssociation.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
