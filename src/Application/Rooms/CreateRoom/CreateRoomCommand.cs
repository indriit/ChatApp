using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Rooms.CreateRoom;

public record CreateRoomCommand(string name, string password, long userId) : ICommand<long>;
