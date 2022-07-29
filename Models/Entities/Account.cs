using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Account
    {
        // Each customers will have a unique account
        // Account contains 2 types of card: Credit Card and Bank Card
        // 1:1 Relation with Customer
        // 1:Many Relation with Card
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; } 

        public ICollection<Card> Cards { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}
