using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Balance :IEntity
    {
        public int Id { get; set; }
        public Double BalanceAmount { get; set; }
        public int MemberId { get; set; }
    }
}
