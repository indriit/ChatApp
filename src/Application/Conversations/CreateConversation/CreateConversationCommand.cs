using ConveApp.Application.Abstractions.Messaging;

namespace ConveApp.Application.Conversations.CreateConversation;

public record CreateConversationCommand(long? roomId, List<long> participants) : ICommand<string>;
