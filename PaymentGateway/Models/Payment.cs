using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGateway.Models
{
    public class Payment
    {
        public string  CardNumber { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public int Cvv { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
    }
}
