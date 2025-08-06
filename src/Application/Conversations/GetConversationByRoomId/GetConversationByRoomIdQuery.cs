using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Conversations.GetConversationByRoomId;

public record GetConversationByRoomIdQuery(long roomId, int page, int pageSize) : IQuery<ConversationResponse>;
