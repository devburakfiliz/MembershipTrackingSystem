using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Surename { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Phone { get; set; }
        public string? Adress { get; set; }
        public int MemberShipFee { get; set; }
        public string? Description { get; set; }
    }
}
