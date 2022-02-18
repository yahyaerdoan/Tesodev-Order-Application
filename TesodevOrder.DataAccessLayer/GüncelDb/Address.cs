using System;
using System.Collections.Generic;

#nullable disable

namespace TesodevOrder.DataAccessLayer.GüncelDb
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CityCode { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
