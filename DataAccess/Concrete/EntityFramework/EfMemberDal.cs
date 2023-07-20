using Core.Concrete.DataAccess.EntityFramework.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal : EfEntityRepositoryBase<Member, MemberAppContext>, IMemberDal
    {
        public MemberRegistration GetByMemberId(Expression<Func<MemberRegistration, bool>> filter = null)
        {
            using (MemberAppContext context = new MemberAppContext())
            {
                var result = from member in context.Members
                             join payment in context.MonthlyPayments on member.MonthlyPaymentId equals payment.Id

                             select new MemberRegistration
                             {
                                 MemberId = member.MemberId,
                                 FirstName = member.FirstName,
                                 LastName = member.LastName,
                                 Phone = member.Phone,
                                 Adress = member.Adress,
                                 StartDate = member.StartDate,
                                 EndDate = member.EndDate,
                                 MonthlyPaymentId = member.MonthlyPaymentId,
                                 Description = member.Description,

                                 Payment = payment.Payment,
                                 PaymentType = payment.PaymentType,
                                 PaymentDate = payment.PaymentDate

                             };

                return filter == null ? result.SingleOrDefault() : result.Where(filter).SingleOrDefault();


            }
        }

        public List<MemberRegistration> GetMemberDetails(Expression<Func<MemberRegistration, bool>> filter = null)
        {
            using (MemberAppContext context = new MemberAppContext())
            {
                var result = from member in context.Members
                             join payment in context.MonthlyPayments on member.MonthlyPaymentId equals payment.Id

                             select new MemberRegistration
                             {
                                 MemberId = member.MemberId,
                                 FirstName = member.FirstName,
                                 LastName = member.LastName,
                                 Phone = member.Phone,
                                 Adress = member.Adress,
                                 StartDate = member.StartDate,
                                 EndDate = member.EndDate,
                                 MonthlyPaymentId = member.MonthlyPaymentId,
                                 Description = member.Description,

                                 Payment = payment.Payment,
                                 PaymentType = payment.PaymentType,
                                 PaymentDate = payment.PaymentDate

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
