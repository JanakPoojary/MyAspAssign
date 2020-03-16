using PromactAsp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromactAsp.Models
{
    public class MessageRepository : IMessageRepository
    {
        private readonly PromactAspContext _context;

        public MessageRepository(PromactAspContext context)
        {
            _context = context;
        }
        public IEnumerable<Message> Allmsg => _context.Message;
        public Message GetMessageById(int messageId)
        {
            return _context.Message.FirstOrDefault(m => m.messageid == messageId);
        }

    }
}
