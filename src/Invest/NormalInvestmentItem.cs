using Logistics;
using System;
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

    public class NormalInvestmentActive<T>
    {
        private Action<T> _active;

        private int _price;

        public NormalInvestmentActive(int price, Action<T> active)
        {
            _price = price;
            _active = active;
        }
    }