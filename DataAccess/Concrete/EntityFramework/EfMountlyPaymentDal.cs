﻿using Core.Concrete.DataAccess.EntityFramework.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMountlyPaymentDal : EfEntityRepositoryBase<MonthlyPayment, MemberAppContext>, IMonthlyPaymentDal
    {
    }
}
