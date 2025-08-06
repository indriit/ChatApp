using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Rooms.JoinRoom;

public record JoinRoomCommand(long roomId, long userId) : ICommand<long>;
