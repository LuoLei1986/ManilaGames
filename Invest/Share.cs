using System;

namespace Invest
{
    public class Share
    {
        private int _price;
        private string _owner;
        
        public Share(int price)
        {
            _price = price;
        }

        public void SetOwner(string owner)
        {
            _owner = owner;
        }

        public bool AvaibleToBuy => string.IsNullOrEmpty(_owner);
    }
}
