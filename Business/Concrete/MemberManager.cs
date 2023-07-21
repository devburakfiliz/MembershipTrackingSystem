using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;
        IMonthlyPaymentDal _paymentDal;

        public MemberManager(IMemberDal memberDal, IMonthlyPaymentDal paymentDal)
        {
            _memberDal = memberDal;
            _paymentDal = paymentDal;
        }

        public IResult Add(Member entity)
        {
            MemberAppContext context = new MemberAppContext();
            var result = _memberDal.GetAll(x => x.FirstName == entity.FirstName && x.LastName == entity.LastName);

            if (!result.Any())
            {
                _memberDal.Add(entity);
                AddedPayment(entity);
                context.SaveChanges(); 
                return new SuccessResult("Üye başarıyla eklendi.");
            }

            return new ErrorResult("Üye zaten mevcut, lütfen üyeyi güncelleyin.");
        }
        

        public IResult Delete(int id)
        {
            var member = GetById(id).Data;

            if (member == null)
            {
                return new ErrorResult("Kullanıcı Bulunamadı.");
            }
            _memberDal.Delete(member);
            return new SuccessResult("Kullanıcı Silindi.");
        }

        public IDataResult<List<MemberRegistration>> GetAll()
        {
            var result = _memberDal.GetMemberDetails();
            return new SuccessDataResult<List<MemberRegistration>>(result);
        }

        public IDataResult<Member> GetById(int id)
        {
            var result = _memberDal.Get(x => x.MemberId == id);
            return new SuccessDataResult<Member>(result);
        }

        public IDataResult<MemberRegistration> GetByMemberId(int id)
        {
            var result = _memberDal.GetByMemberId(x =>  x.MemberId == id);
            return new SuccessDataResult<MemberRegistration>(result);


        }

        public IResult Update(Member entity)
        {
            _memberDal.Update(entity);
            AddedPayment(entity);

            return new SuccessResult("Kullanıcı Güncellendi.");
        }


        private IResult AddedPayment(Member entity)
        {
            var memberpayment = new MonthlyPayment 
            {
                Payment = entity.Payment,
                PaymentType = entity.PaymentType,
                PaymentDate = DateTime.Now,
                MemberId = entity.MemberId,
                UserId = entity.UserId
            };

            _paymentDal.Add(memberpayment);

            return new SuccessResult();
        }



    }
}
