using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    //Methods is described for Customer class via interface
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public Customer GetByIdentity(string identity);
        public void Delete(Customer customer);
        public void Update(Customer customer);
        public void Create(Customer customer);
    }
}
