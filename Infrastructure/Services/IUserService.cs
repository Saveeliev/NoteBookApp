using Dto.User;
using DTO;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IUserService
    {
        Task<ActionResult> Register(RegisterRequest request);
        Task<ActionResult> Login(LoginRequest request);
        Task<ActionResult> SetActiveUser(LoginRequest request);
        ActiveUser GetAndSetActiveUserIfExist();
        void DeleteActiveUser();
    }
}