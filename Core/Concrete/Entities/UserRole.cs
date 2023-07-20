using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class UserRole:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
}
