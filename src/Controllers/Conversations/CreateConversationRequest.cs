namespace ConveApp.Controllers.Conversations;

public record CreateConversationRequest(long? roomId, List<long> participants);
