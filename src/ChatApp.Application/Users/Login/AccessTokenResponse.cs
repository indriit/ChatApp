using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Users.Login
{
    public sealed record AccessTokenResponse(string accessToken, string username);
}