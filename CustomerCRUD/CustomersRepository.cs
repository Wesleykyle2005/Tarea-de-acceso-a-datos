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
            try
            {
                List<Customer> customers = _dbCustomer.customers.ToList();
                return customers;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener a los clientes de la base de datos: {ex.Message}");
            }
        }
        public Customer GetValue(int id)
        {
            try
            {
                Customer customer = _dbCustomer.customers.Find(id);
                return customer;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener de la base de datos: {ex.Message}");
            }
        }                       
        public void Insert(Customer customer)
        {
            try
            {
                Customer customerToAdd = new Customer
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                };
                _dbCustomer.Add(customerToAdd);
                _dbCustomer.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar en la base de datos: {ex.Message}");
            }
        }

        public void Update(Customer customer)
        {
            try
            {
                Customer customerToUpdate = GetValue(customer.Id);
                customerToUpdate.FirstName = customer.FirstName;
                customerToUpdate.LastName = customer.LastName;
                _dbCustomer.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el cliente de la base de datos: {ex.Message}");
            }
        }
        public void Delete(int id)
        {
            try
            {
                Customer customer = GetValue(id);
                _dbCustomer.customers.Remove(customer);
                _dbCustomer.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar de la base de datos: {ex.Message}");
            }
        }
    }
}
