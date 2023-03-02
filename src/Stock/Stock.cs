using System;

namespace Stocks
{
    public class Stock
    {
        private string _id;
        private string _name;
        private int _price;
        private int _circulation;
        private int _inventory;
        public Stock(string id,string name, int circulation)
        {
            _id = id;
            _name = name;
            _price = 0;
            _circulation = circulation;
            _inventory = circulation;
        }

        public Stock(string name,  int circulation)
        {
            _id = name;
            _name = name;
            _price = 0;
            _circulation = circulation;
             _inventory = circulation;
        }

        public int GetPrice()
        {
            return _price;
        }

        public bool UpdatePrice(int previousPrice, int currentPrice)
        {
            if(_price != previousPrice)
                return false;
            
            _price = currentPrice;
            return true;
        }

        public bool Buy(string stockName, int buyPrice, int quantity)
        {
            if(_price != buyPrice)
                return false;

            if(_inventory < quantity)
                return false;

             _inventory = _inventory - quantity;
            return true;
        }

        public bool Sell(string stockName, int sellPrice, int quantity)
        {
            if(_price != sellPrice)
                return false;

            if(_circulation <= _inventory + quantity)
                 return false;

            _inventory = _inventory + quantity;
            return true;
        }

        public bool NotAvaibleBuy => _inventory == 0; 

        public bool NotAvaibleSell => _inventory == _circulation; 


    }

}
