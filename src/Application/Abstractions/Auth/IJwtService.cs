using ConveApp.Domain.Abstractions;

namespace ConveApp.Application.Abstractions.Auth;

public interface IJwtService
{
    Result<string> GetAccessToken(string name, string email, long userId);
}
