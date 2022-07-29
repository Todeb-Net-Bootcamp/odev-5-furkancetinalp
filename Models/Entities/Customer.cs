using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Customer
    {
        // This is to store information of each customer individuals.
        // 1:Many relation with CustomerList
        // Customer entity also has 1:1 relation with Address because their addresses are stored in Adress class
        [Key]
        public int Id { get; set; }

        public int CustomerListId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public Account Account { get; set; }

        [ForeignKey("CustomerListId")]
        public CustomerList CustomerList { get; set; }

        public Address Address { get; set; }



    }
}
