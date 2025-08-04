using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Rooms.Responses
{
    public class RoomResponse
    {
        public string Name { get; init; }
        public List<MemberResponse> Members { get; init; }
    }
}