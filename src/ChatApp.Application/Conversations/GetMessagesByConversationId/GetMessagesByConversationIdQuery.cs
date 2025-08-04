using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.GetMessagesByConversationId
{
    public record GetMessagesByConversationIdQuery(string conversationId) : IQuery<List<MessageResponse>>;
}