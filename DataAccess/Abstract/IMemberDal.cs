using Core.Abstract.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMemberDal : IEntityRepository<Member>
    {
        List<MemberRegistration> GetMemberDetails(Expression<Func<MemberRegistration, bool>> filter = null);
        MemberRegistration GetByMemberId(Expression<Func<MemberRegistration, bool>> filter = null);
    }
}
