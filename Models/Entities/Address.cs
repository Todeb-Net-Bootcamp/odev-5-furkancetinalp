using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Address
    {
        //This class is to store address info of customers
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public int HouseCode { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
