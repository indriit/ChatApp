using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Users.Login;

public record LoginUserQuery(string email, string password) : IQuery<AccessTokenResponse>;
