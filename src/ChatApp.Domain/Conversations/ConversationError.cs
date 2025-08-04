using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Domain.Abstractions;

namespace ChatApp.Domain.Conversations
{

    public static class ConversationErrors
    {
        public static Error InvalidGroupConversation = Error.BadRequest(
            "Conversation.InvalidGroupConversation",
            "Group conversations require a RoomId and should not have participants in the list");

        public static Error InvalidDirectConversation = Error.NotFound(
            "Conversation.InvalidDirectConversation",
            "User to user conversation requires exactly two participants and no RoomId");
    }
}