using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    // This is to store addresses of the banks. 
    //1:1 relation with Bank using BankId
    public class BankAddress
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public int BankId { get; set; }

        [ForeignKey("BankId")]
        public Bank Bank { get; set; }

    }
}
