using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Customer
{
    //Deleting action will be made via identity number of users.
    public class DeleteCustomerRequest
    {
        public string IdentityNumber { get; set; }
    }
}
