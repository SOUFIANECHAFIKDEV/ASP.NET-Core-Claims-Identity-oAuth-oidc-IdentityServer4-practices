using Jwt.Domain;
using System.Threading.Tasks;

namespace Jwt.Services
{
    interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}
