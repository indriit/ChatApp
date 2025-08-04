using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Rooms.JoinRoom
{
    public record JoinRoomCommand(long roomId, long userId) : ICommand<long>;
}