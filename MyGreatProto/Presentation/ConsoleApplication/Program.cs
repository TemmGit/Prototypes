using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGreatProto.CoreDal;
using MyGreatProto.CoreDataModel;

namespace ConsoleApplication
{
	class Program
	{
        static void Main(string[] args)
        {
     
            using (var cusCtx = new CoreContext())
            {
				Customer cust = new Customer() { FirstName = "First", LastName = "Last", BirthDay = DateTime.Now, Address = new Address() };
				cusCtx.Customers.Add(cust);
				cusCtx.SaveChanges();                
            }
        }
    }
}
