using Microsoft.AspNetCore.Mvc;
using PaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaymentGateway.Controllers
{
    [Produces("application/json")]
    [Route("api/customerbank")]
    public class CustomerBankController : ControllerBase

    {
        ///mocking the bank variables
            int amount = 500;
            string cardNumber = "5555555555554444";

        [HttpPost]
        public IActionResult PaymentDetails([FromBody] CustomerBank paymentDetails)
        {
            Guid guid = Guid.NewGuid();
            string reference = guid.ToString();

            if (paymentDetails.cardNumber.Equals(cardNumber) && (paymentDetails.amount >= amount))
            {
                reference = guid.ToString();
                paymentDetails.reference = reference;
                paymentDetails.status = "successful";
                return Ok(paymentDetails);
            }

            else
                paymentDetails.status = "unsuccessful";
                return BadRequest(paymentDetails);
        }

    }
}
