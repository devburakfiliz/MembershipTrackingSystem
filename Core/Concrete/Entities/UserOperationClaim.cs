using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string? AuthTag { get; set; }
        public string Operation { get; set; }

    }
}
