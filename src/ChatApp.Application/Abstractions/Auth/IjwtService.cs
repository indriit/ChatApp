using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Domain.Abstractions;

namespace ChatApp.Application.Conversations.Abstractions.Auth
{
    public interface IJwtService
    {
        Result<string> GetAccessToken(string name, string email, long userId);
    }
}