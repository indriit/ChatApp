using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.ConversationResponse
{
    public class MessageResponse
    {
        public string SenderName { get; init; }
        public string Content { get; init; }
        public DateTime CreatedOn { get; init; }
    }
}