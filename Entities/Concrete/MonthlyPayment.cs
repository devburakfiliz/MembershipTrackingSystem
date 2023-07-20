using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MonthlyPayment: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MemberId { get; set; }
        public bool Payment { get; set;}
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
