using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Rooms.Responses
{
    public class MemberResponse
    {
        public string Name { get; init; }
        public string Role { get; init; }
        public DateTime JoinedOn { get; init; }
    }
}