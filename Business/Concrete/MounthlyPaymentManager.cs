using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MounthlyPaymentManager : IMounthlyPaymentService
    {
        IMonthlyPaymentDal _monthlyPaymentDal;

        public MounthlyPaymentManager(IMonthlyPaymentDal monthlyPaymentDal)
        {
            _monthlyPaymentDal = monthlyPaymentDal;
        }

        public IResult Add(MonthlyPayment entity)
        {
            _monthlyPaymentDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MonthlyPayment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MonthlyPayment>> GetByMemberId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MonthlyPayment entity)
        {
            throw new NotImplementedException();
        }
    }
}
