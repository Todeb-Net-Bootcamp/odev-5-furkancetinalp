using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    //Every bank will have its own Id
    // 1:1 Relations with BankAddress
    // 1:1 Relations with CustomerList

    public class Bank
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public BankAddress BankAddress {get;set;}

        public CustomerList CustomerList { set; get; }
    }
}
