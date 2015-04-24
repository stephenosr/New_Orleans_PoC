using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;

using SMS.Definitions.Classes;
using SMS.IFeePaymentGrain.Interfaces;
using Orleans.Providers;
using Orleans.Concurrency;


namespace SMS.FeePaymentGrain.Class
{
    public interface FeePaymentState : IGrainState
    {
         Guid FeeID { get; set; }
         double FeeAmount { get; set; }
         string FeeCode { get; set; }
         DateTime Date { get; set; }
         string StudentID { get; set; }
    }

    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    [StorageProvider(ProviderName = "AzureStore")]
    //[Reentrant]
    public class FeePaymentGrain : Grain<FeePaymentState>, IFeePaymentGrain.Interfaces.IFeePaymentGrain
    {
        private FeePayment _feePayment;

        public override Task OnActivateAsync()
        {
            var id = this.GetPrimaryKey();
            Console.WriteLine("Primary key ID - {0}", id);
            return base.OnActivateAsync();
        }


        public async Task MakePayment(Fees payment)
        {
            bool bFailed = false;
            try
            {
                this.State.FeeAmount = payment.FeeAmount;
                this.State.FeeCode = payment.FeeCode;
                this.State.FeeID = payment.FeeID;
                this.State.StudentID = payment.StudentID;
                this.State.Date = payment.Date;

                await this.State.WriteStateAsync();

                Console.WriteLine("Your payment is {0}", payment);
                string _grainID = base.IdentityString;
                Console.WriteLine("The Grain ID is {0}", _grainID);
                
                //_feePayment = payment;
                //this.State.FeeStoredValue = payment;
                //Task.Run(() => SaveFee());
                //return Task.FromResult( string.Format("Payment made {0}",payment.ToString()));
                //return TaskDone.Done;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error");
                bFailed = true;
               
            }
            if (bFailed) await Task.Run(() => { return "Error"; });
        }

        public Task<double> FetchFee(Guid FeeID)
        {

            this.State.FeeID = FeeID;
            return Task.FromResult<double>(this.State.FeeAmount);
        }

        //private async Task SaveFee()
        //{
        //    Console.WriteLine("\n\nSaving fee...\n\n");
        //    this.State.FeeStoredValue = _feePayment;

        //    await this.State.WriteStateAsync();

        //    Console.WriteLine("\n\nSaved fee...\n\n");
        //}


    }
}
