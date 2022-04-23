using System;

namespace Stocks
{
    public class Account
    {

        public string _id;
        public string _name;
        public int _price;
        public int _circulation;
        public Account(string id,string name, int price, int circulation)
        {
            _id = id;
            _name = name;
            _price = price;
            _circulation = circulation;
        }

        public Account(string name, int price, int circulation)
        {
            _id = name;
            _name = name;
            _price = price;
            _circulation = circulation;
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


    }

}
