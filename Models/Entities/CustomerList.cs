using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    //This is to store all customers rows in the table via their own unique CustomerId
    // 1:Many Relation with Customers which mean CustomerList contains many Customers
    public class CustomerList
    {
        [Key]
        public int Id { get; set; }
        public int BankId { get; set; }
        
        [ForeignKey("BankId")]
        public Bank Bank { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}
