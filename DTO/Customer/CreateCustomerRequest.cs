using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Customer
{
    //DTO for creating a bank user(customer).
    //CustomerListId represents the list of each banks which means banks will have their own customer list.
    public class CreateCustomerRequest
    {
        public int CustomerListId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
    }
}
