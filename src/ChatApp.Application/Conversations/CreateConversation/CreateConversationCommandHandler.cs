using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Domain.Abstractions;
using ChatApp.Domain.Conversations;

namespace ChatApp.Application.Conversations.CreateConversation
{
    internal sealed class CreateConversationCommandHandler : ICommandHandler<CreateConversationCommand, string>
    {
        private readonly IConversationRepository _conversationRepository;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CreateConversationCommandHandler(IConversationRepository conversationRepository, IDateTimeProvider dateTimeProvider)
        {
            _conversationRepository = conversationRepository;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<Result<string>> Handle(CreateConversationCommand request, CancellationToken cancellationToken)
        {
            var isGroup = request.roomId is not null && request.roomId > 0 ? true : false;

            var conversation = Conversation.Create(request.roomId, request.participants, isGroup, _dateTimeProvider.UtcNow);

            await _conversationRepository.AddAsync(conversation);

            return conversation.Id;
        }
    }
}