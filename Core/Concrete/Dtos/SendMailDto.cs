using Core.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Dtos
{
    public class SendMailDto
    {
        public MailParameter? mailParameter { get; set; }
        public string email { get; set; }
        public string emailReceiver { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        public string userEmail { get; set; }

    }
}
