using System.Threading.Tasks;
using Abp.Application.Services;
using Mf.Authorization.Accounts.Dto;

namespace Mf.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
