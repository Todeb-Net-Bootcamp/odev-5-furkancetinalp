using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Card
    {
        //This class includes information about card
        // Each card has balance(amount of money), unique IBAN 
        // 1:Many relation with CardType
        // 1:1 Relation with Account
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CardTypeId { get; set; }
        public decimal balance { get; set; }
        public string IBAN { get; set; }

        [ForeignKey("CardTypeId")]
        public CardType CardType { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }


    }
}
