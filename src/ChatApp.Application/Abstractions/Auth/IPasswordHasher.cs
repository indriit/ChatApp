using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.Abstractions.Auth
{
    public interface IPasswordHasher
    {
        string GenerateSalt();
        string Hash(string password, string salt);
        bool Verify(string enteredPassword, string storedPasswordHash);
    }
}