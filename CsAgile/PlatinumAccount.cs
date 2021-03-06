﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsAgile
{
    public class PlatinumAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor((Balance / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint)), 0);
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}