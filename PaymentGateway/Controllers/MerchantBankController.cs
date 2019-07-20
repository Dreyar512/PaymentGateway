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
        [HttpPost]
        public IActionResult PaymentDetails([FromBody] MerchantBank paymentDetails)
        {
            //mocking merchant bank
            //deposit amount 

            int? amount = paymentDetails.amount;

            if(amount != null)
            {
                paymentDetails.status = "successful";
                return Ok(paymentDetails);
            }
            else
            {
                paymentDetails.status = "unsuccessful";
                return BadRequest(paymentDetails);
            }
        }
    }
}
