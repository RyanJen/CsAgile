using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsAgile
{
    public class BronzeAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor(amount / BronzeTransactionCostPerPoint), 0);
        }

        private const int BronzeTransactionCostPerPoint = 5;
    }
}