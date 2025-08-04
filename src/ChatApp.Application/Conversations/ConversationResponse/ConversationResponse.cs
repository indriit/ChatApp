using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.ConversationResponse
{
    public class ConversationResponse
    {
        public long? RoomId { get; init; }
        public List<long> Participants { get; init; }
        public List<MessageResponse> Messages { get; init; }
    }
}