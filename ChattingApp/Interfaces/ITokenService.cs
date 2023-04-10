using ChattingApp.Entities;

namespace ChattingApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
