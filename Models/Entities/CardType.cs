using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class CardType
    {
        // This class includes to distinquish card types: Credit Card or Bank Card
        // There could be more than one card type, this is because it has 1:Many relation with 'Card' class
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}
