using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Rooms.CreateRoom
{
    public record CreateRoomCommand(string name, string password, long userId) : ICommand<long>;
}