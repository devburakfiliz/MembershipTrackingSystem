using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMounthlyPaymentService
    {
        IDataResult<List<MonthlyPayment>> GetAll();
        IResult Update(MonthlyPayment entity);
        IResult Delete(int id);
        IResult Add(MonthlyPayment entity);
        IDataResult<List<MonthlyPayment>> GetByMemberId(int id);
    }
}
