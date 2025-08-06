using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Conversations.CreateConversation;

public record AddMessageCommand(long roomId, long senderId, string content) : ICommand<string>;
