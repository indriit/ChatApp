using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Application.Conversations.AddMessages
{
    public record AddMessageCommand(long roomId, long senderId, string content) : ICommand<string>;
}