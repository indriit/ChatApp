using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Users.Register;

public record RegisterUserCommand(string name, string email, string password) : ICommand<long>;
