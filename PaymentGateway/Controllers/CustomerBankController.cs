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
        int Amount = 500;
        string CardNumber = "5555555555554444";

        //Retrieve payment details from payment gateway
        //withdraw money 

        [HttpPost]
        public IActionResult PaymentDetails([FromBody] CustomerBank paymentDetails)
        {
            Guid guid = Guid.NewGuid();
            string reference = guid.ToString();

            if (paymentDetails.CardNumber.Equals(CardNumber) && (paymentDetails.Amount >= Amount))
            {
                //generate a reference
                reference = guid.ToString();

                paymentDetails.Reference = reference;
                paymentDetails.Status = "successful";
                return Ok(paymentDetails);
            }

            else
                paymentDetails.Status = "unsuccessful";
                return BadRequest(paymentDetails);
        }

    }
}
