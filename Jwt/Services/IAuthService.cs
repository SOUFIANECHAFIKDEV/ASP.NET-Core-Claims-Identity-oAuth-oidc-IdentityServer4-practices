using Jwt.Domain;
using System.Threading.Tasks;

namespace Jwt.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}
