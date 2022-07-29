using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Account
{
    //Account can only be created according to customerId. If customerId does not exist, it'll throw an error.
    public class CreateAccountRequest
    {
        public int CustomerId { get; set; }


    }
}
