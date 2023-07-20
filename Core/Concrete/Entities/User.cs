using Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int? DealerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? ErpReference { get; set; }
        public string? ClientTitle { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsKvkk { get; set; }
        public string? SalesmanCode { get; set; }
    }
}
