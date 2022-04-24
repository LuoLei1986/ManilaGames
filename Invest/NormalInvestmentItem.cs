public class NormalInvestmentItem
    {
        private int _totalEarnings;

        private int _price;

        public NormalInvestmentItem(int totalEarnings, int price)
        {
            _totalEarnings = totalEarnings;
            _price = price;
        }

         public int EarningsPerShare => _totalEarnings;

    }