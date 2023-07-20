using Core.Concrete.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class MemberAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= BURAK;Database=DbMemberApp;Trusted_Connection=True");

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<MonthlyPayment> MonthlyPayments { get; set; }
    }
}
