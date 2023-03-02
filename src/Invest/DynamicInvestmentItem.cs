using System;
using System.Collections.Generic;
using System.Linq;

namespace Invest
{
    public class DynamicInvestmentItem
    {
        private int _totalEarnings;

        private List<Share> _shares;

        public DynamicInvestmentItem(int totalEarnings, List<Share> shares)
        {
            _totalEarnings = totalEarnings;
            _shares = shares;
        }

         public int TotalShares=> _shares.Count();

         public List<Share> AvaibleShares =>_shares.Where(x=>x.AvaibleToBuy).ToList();

         private List<Share> BuyedShares =>_shares.Where(x=>!x.AvaibleToBuy).ToList();

         public int EarningsPerShare => _totalEarnings/BuyedShares.Count();
    }
}
