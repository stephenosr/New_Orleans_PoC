﻿using Orleans;
using SMS.Definitions.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.IFeePaymentGrain.Interfaces
{
    public interface IFeeManager : IGrain
    {
        Task FeePaymentStall(Fees Fee);
        Task<Fees> FeeEnquiry(Guid FeeID);
    }
}
