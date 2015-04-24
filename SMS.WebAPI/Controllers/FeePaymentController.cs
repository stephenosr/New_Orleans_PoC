using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Orleans;
using Orleans.Runtime.Host;
using BrightSword.SwissKnife;
using Newtonsoft.Json;

using SMS.Definitions.Classes;

namespace SMS.WebAPI.Controllers
{
    public class FeeDetails
    {
        public string StudenID { get; set; }
        public DateTime PaidDate { get; set; }
        public string FeeBlob { get; set; }
    }

    internal class FeeBlob
    {

        internal string Type { get; set; }
        internal string Amount { get; set; }
    }

    public class FeesController : ApiController
    {
        //[HttpPost]
        ////[ActionName("FeeCredit")]
        //public async Task<IHttpActionResult> FeePayment(Guid StudenID, string FeeCode, double FeeAmount)
        //{

        //    var feeGrain = IFeePaymentGrain.Interfaces.FeeManagerFactory.GetGrain(Guid.NewGuid());
        //    FeePayment FeePymnt = new FeePayment()
        //    {
        //        Fee = new Fees()
        //        {
        //            FeeAmount = FeeAmount,
        //            FeeCode = FeeCode,
        //            FeeID = SequentialGuid.NewSequentialGuid(),
        //            Date = DateTime.Now
        //        },

        //        StudentFee = new Student()
        //        {
        //            StudentID = Guid.NewGuid()
        //        }
        //    };

        //    await feeGrain.FeePaymentStall(FeePymnt);
        //    return Ok(FeePymnt.Fee.FeeID);
        //}


        [HttpPost]
        //[ActionName("FeeCredit")]
        public HttpResponseMessage RegisterFee(FeeDetails Fees)
        {

            string[] fee = Fees.FeeBlob.Split('|');
            //string j = Fees.FeeBlob.Replace("\"", "\"");
            //FeeBlob FeeDetail = JsonConvert.DeserializeObject<FeeBlob>(j);

            Fees FeePymnt = new Fees()
            {
                //the 2 hacks need to be done away and assigned more elegantly :) - SORD
                FeeAmount = double.Parse(fee[3]), // double.Parse(FeeDetail.Amount.ToString()),
                FeeCode = fee[1], //FeeDetail.Type,
                FeeID = Guid.NewGuid(), //SequentialGuid.NewSequentialGuid(),
                Date = DateTime.Now

            };

            try
            {
                var ClientConfig = System.Web.Hosting.HostingEnvironment.MapPath("~/docs/DevTestClientConfiguration.xml");

                //Orleans work - It stopped working now- Target Silo is unavailable??- SORD
                Orleans.GrainClient.Initialize(ClientConfig);

                var feeGrain = IFeePaymentGrain.Interfaces.FeeManagerFactory.GetGrain(Guid.NewGuid());
                feeGrain.FeePaymentStall(FeePymnt);
                return Request.CreateResponse(HttpStatusCode.OK, FeePymnt.FeeID);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, "Error while invoking Silo");
            }
        }


        [HttpGet]
        [ActionName("FeeTest")]
        public HttpResponseMessage FeeTest(Guid StudenID, string FeeCode, double FeeAmount)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "All workign");
        }

        [HttpGet]
        public HttpResponseMessage TestMethod()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Test Method");
        }
    }
}
