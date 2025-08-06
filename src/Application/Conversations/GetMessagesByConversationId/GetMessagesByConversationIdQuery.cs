using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Conversations.GetMessagesByConversationId;

public record GetMessagesByConversationIdQuery(string conversationId) : IQuery<List<MessageResponse>>;
