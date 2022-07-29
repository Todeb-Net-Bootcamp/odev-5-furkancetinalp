using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Account
{
    //Account can be updated via customerId
    public class UpdateAccountRequest
    {
        public int CustomerId { get; set; }

    }
}
