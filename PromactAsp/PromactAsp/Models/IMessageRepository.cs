using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromactAsp.Models
{
    public interface IMessageRepository
    {
        IEnumerable<Message> Allmsg { get; }
        Message GetMessageById(int messageId);
    }
}
