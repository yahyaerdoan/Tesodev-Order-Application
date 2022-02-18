using System;
using System.Collections.Generic;
using TesodevOrder.CoreLayer.Concrete.Entities;

#nullable disable

namespace TesodevOrder.EntityLayer.Concrete.Models
{
    public partial class Product : Entity
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
