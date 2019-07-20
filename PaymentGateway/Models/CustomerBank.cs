using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGateway.Models
{
    public class CustomerBank
    {
        public string cardNumber { get; set; }
        public string date { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public int cvv { get; set; }
        public string reference { get; set; }
        public string status { get; set; }
    }
}
