using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public string Shipping { get; set; }
        public int RushOrder { get; set; }

        public Desk Desk { get; set; }

    }
}
