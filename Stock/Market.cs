using System;
using System.Collections.Generic;
using System.Linq;

namespace Stocks
{
    public class Market
    {
        public string id;
        private Dictionary<string, Stock> _stocks;
        public Market()
        {
            id = Guid.NewGuid().ToString();
            _stocks = new Dictionary<string, Stock>();
        }

        public bool Listed(string stockName, int IPOprice, int count)
        {
            if(IsExisted(stockName))
                return false;
            
            _stocks.Add(stockName, new Stock(stockName, IPOprice, count));
            return true;
        }

        public bool IsExisted(string stockName)
        {
           return _stocks.ContainsKey(stockName);
        }

        public bool ChangeStockPrice(string stockName, int previousPrice, int currentPrice)
        {
             if(IsExisted(stockName))
                return false;

            return _stocks[stockName].UpdatePrice(previousPrice, currentPrice);
        }

        public List<Stock> AllStocks()
        {
            return _stocks.Values.ToList();
        }
    }
}
