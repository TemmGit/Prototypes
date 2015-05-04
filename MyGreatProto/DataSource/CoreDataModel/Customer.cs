using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGreatProto.CoreDataModel
{
    public class Customer
    {
		public int CustomerId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDay { get; set; }
		public Address Address { get; set; }

		public List<Order> Orders { get; set; }

    }
}
