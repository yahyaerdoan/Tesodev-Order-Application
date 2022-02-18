using System;
using System.Collections.Generic;
using TesodevOrder.CoreLayer.Concrete.Entities;

#nullable disable

namespace TesodevOrder.EntityLayer.Concrete.Models
{
    public partial class Customer : Entity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid AddressId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
