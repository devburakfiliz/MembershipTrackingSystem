using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class MailParameter :IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? EmailReceiver { get; set; }
        public string? Password { get; set; }
        public string? SMTP { get; set; }
        public int Port { get; set; }
        public bool SSL { get; set; }
    }
}
