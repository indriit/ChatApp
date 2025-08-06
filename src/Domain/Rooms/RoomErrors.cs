using ConveApp.Domain.Abstractions;

namespace ConveApp.Domain.Rooms;

public static class RoomErrors
{
    public static Error MemberAlreadyExists = Error.Conflict(
        "Room.MemberAlreadyExists",
        "Member with provided userId already exists");

    public static Error NotFound = Error.NotFound(
        "Room.NotFound",
        "The room with the specified id was not found");

}
