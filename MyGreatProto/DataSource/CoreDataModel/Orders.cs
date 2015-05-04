using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGreatProto.CoreDataModel
{
	public class Order
	{
		public int OrderID { get; set; }
		public Customer Acquier { get; set; }
		public List<BaseDocument> Document { get; set; }
	}
}
