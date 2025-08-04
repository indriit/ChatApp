using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Domain.Abstractions;

namespace ChatApp.Domain.Users
{
    public static class UserErrors
    {
        public static Error AlreadyExists = Error.Conflict(
            "User.AlreadyExists",
            "User with provided email already exists");

        public static Error NotFound = Error.NotFound(
            "User.Found",
            "The user with the specified identifier was not found");

        public static Error InvalidCredentials = Error.Conflict(
            "User.InvalidCredentials",
            "The provided credentials were invalid");

    }
}