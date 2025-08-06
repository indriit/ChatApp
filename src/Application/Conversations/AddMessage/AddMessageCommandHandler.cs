using ConveApp.Application.Abstractions.Clock;
using ConveApp.Application.Abstractions.Messaging;
using ConveApp.Domain.Abstractions;
using ConveApp.Domain.Conversations;
using ConveApp.Domain.Users;
using ConveApp.Infrastructure.Repositories;

namespace ConveApp.Application.Conversations.CreateConversation;

internal sealed class AddMessageCommandHandler : ICommandHandler<AddMessageCommand, string>
{
    private readonly IConversationRepository _conversationRepository;
    private readonly IMessageRepository _messageRepository;
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IUserRepository _userRepository;

    public AddMessageCommandHandler(IMessageRepository messageRepository, IDateTimeProvider dateTimeProvider, IUserRepository userRepository, IConversationRepository conversationRepository)
    {
        _messageRepository = messageRepository;
        _dateTimeProvider = dateTimeProvider;
        _userRepository = userRepository;
        _conversationRepository = conversationRepository;
    }

    public async Task<Result<string>> Handle(AddMessageCommand request, CancellationToken cancellationToken)
    {
        var conversation = await _conversationRepository.GetByRoomId(request.roomId);

        if (conversation is null)
        {
            return Result.Failure<string>(Error.NullValue);
        }

        var user = await _userRepository.GetById(request.senderId);

        var message = Message.Create(conversation.Id, request.senderId, user.Name, request.content, _dateTimeProvider.UtcNow);

        await _messageRepository.AddAsync(message);

        return message.Id;
    }
}
