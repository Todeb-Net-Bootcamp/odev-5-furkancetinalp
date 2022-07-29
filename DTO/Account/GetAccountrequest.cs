using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Account
{
    //DTO to present Account information
    public class GetAccountrequest
    {
        public int CustomerId { get; set; }
        public IEnumerable<Card> Cards { get; set; }

    }
}
