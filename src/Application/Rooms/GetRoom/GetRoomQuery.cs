using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Rooms.GetRoom;

public record GetRoomQuery(long roomId) : IQuery<RoomResponse>;
