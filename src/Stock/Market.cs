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
            InitStocks();
        }

        private void InitStocks()
        {
            Listed("plant", 5);
            Listed("jade", 5);
            Listed("ginseng", 5);
            Listed("silk",5);
        }

        public bool Listed(string stockName, int count)
        {
            if(IsExisted(stockName))
                return false;
            
            _stocks.Add(stockName, new Stock(stockName, count));
            return true;
        }

        public bool IsExisted(string stockName)
        {
           return _stocks.ContainsKey(stockName);
        }

        public bool UpdateStockPrice(string stockName, int previousPrice, int currentPrice)
        {
             if(IsExisted(stockName))
                return false;

            return _stocks[stockName].UpdatePrice(previousPrice, currentPrice);
        }

        public List<Stock> AllStocks()
        {
            return _stocks.Values.ToList();
        }

        public bool ExistedStockPriceAchived30()
        {
            return _stocks.Any(x => x.Value.GetPrice() == 30);
        }
    }
}
