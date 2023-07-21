using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class MailTemplate :IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Type { get; set; }
        public string? Value { get; set; }
    }
}
