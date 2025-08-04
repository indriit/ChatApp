using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.GetConversationByRoomId
{
    public record GetConversationByRoomIdQuery(long roomId, int page, int pageSize) : IQuery<ConversationResponse>;
}