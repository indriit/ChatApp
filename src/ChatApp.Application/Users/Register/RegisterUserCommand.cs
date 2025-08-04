using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Users.Register
{
    public record RegisterUserCommand(string name, string email, string password) : ICommand<long>;
}