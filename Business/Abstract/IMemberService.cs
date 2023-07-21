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
    public interface IMemberService
    {
        IDataResult<List<MemberRegistration>> GetAll();
        IResult Update(Member entity);
        IResult Delete(int id);
        IResult Add(Member entity);
        IDataResult<MemberRegistration> GetByMemberId(int id);
        IDataResult<Member> GetById(int id);

    }



}