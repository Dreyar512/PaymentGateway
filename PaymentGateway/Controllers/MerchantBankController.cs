using Microsoft.AspNetCore.Mvc;
using PaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGateway.Controllers
{
    [Produces("application/json")]
    [Route("api/merchantbank")]

    public class MerchantBankController : ControllerBase
    {
        //Retrieve payment details from payment gateway
        //Deposit money withdraw from customer bank in merchant bank
        [HttpPost]
        public IActionResult PaymentDetails([FromBody] MerchantBank paymentDetails)
        {
            //mocking merchant bank
            //deposit amount 

            int? amount = paymentDetails.Amount;

            if(amount != null)
            {
                paymentDetails.Status = "successful";
                return Ok(paymentDetails);
            }
            else
            {
                paymentDetails.Status = "unsuccessful";
                return BadRequest(paymentDetails);
            }
        }
    }
}
