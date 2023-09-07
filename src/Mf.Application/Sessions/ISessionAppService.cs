using System.Threading.Tasks;
using Abp.Application.Services;
using Mf.Sessions.Dto;

namespace Mf.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
