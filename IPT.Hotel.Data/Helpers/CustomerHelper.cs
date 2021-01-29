using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.Hotel.Data.Helpers
{
    public class CustomerHelper
    {
        public void Insert( string Name, string FatherName, string Phone, string Address, string Email )
        {
            Customer customer = new Customer();
            customer.Name = Name;
            customer.FatherName = FatherName;
            customer.Phone = Phone;
            customer.Address = Address;
            customer.Email = Email;

            var db = new HOTELEntities1();
            db.Customers.Add(customer);
            db.SaveChanges();
            db.Dispose();

        }
        public List<Customer> GetAllCustomer()
        {
            var db = new HOTELEntities1();
            return db.Customers.ToList();
        }
    }
}
