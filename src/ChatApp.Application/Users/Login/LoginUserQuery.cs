using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Users.Login
{
    public record LoginUserQuery(string email, string password) : IQuery<AccessTokenResponse>;
}