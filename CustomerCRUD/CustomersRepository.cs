using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCRUD.Data;
using SharedModels;

namespace CustomerCRUD
{
    public class CustomersRepository : IRepository<Customer>
    {
        private AutoLotContext _dbCustomer = new AutoLotContext();
        public IEnumerable<Customer> GetAll()
        {
            List<Customer> customers = _dbCustomer.customers.ToList();
            return customers;  
        }
        public Customer GetValue(int id)
        {
            Customer customer = _dbCustomer.customers.Find(id);
            return customer;
        }                       
        public void Insert(Customer customer)
        {
            Customer customerToAdd = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
            };
            _dbCustomer.Add(customerToAdd);
            _dbCustomer.SaveChanges();
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate = GetValue(customer.Id);
            customerToUpdate.FirstName = customer.FirstName;
            customerToUpdate.LastName = customer.LastName;  
            _dbCustomer.SaveChanges();
        }
        public void Delete(int id)
        {
            Customer customer = GetValue(id);
            _dbCustomer.customers.Remove(customer);
            _dbCustomer.SaveChanges();
        }
    }
}
