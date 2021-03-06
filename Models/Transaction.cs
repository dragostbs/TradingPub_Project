using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPub.Models
{
    // Buy/Sell info
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int TraderID { get; set; }
        public int QuotationID { get; set; }
        public Trader Trader { get; set; }
        public Quotation Quotation { get; set; }
    }
}
