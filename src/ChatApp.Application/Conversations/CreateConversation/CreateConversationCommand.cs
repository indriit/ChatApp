using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.CreateConversation
{
    public record CreateConversationCommand(long? roomId, List<long> participants) : ICommand<string>;
}