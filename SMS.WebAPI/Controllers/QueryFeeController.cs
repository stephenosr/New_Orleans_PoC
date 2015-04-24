using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;

using SMS.Definitions.Classes;

namespace SMS.WebAPI.Controllers
{
    public class QueryFeeController : ApiController
    {

        [HttpPost]
        public async Task<HttpResponseMessage> FetchFee(Guid FeeID)
        {
            var feeGrain = IFeePaymentGrain.Interfaces.FeeManagerFactory.GetGrain(0);
            Fees feeDetails = await feeGrain.FeeEnquiry(FeeID); //Not sure if this has to be the long or Guid - Steve
            //The type that is returned will be the type it is JSON deserialized to in the client.
            return Request.CreateResponse(HttpStatusCode.OK, feeDetails);
        }



    }
}
