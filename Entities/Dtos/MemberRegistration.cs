using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MemberRegistration :IDto
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Phone { get; set; }
        public string? Adress { get; set; }
        public int MonthlyPaymentId { get; set; }
        public string? Description { get; set; }


        public bool Payment { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
