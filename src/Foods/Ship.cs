using System;
using System.Collections.Generic;

namespace Logistics
{
    public class Ship
    {
        private int _id;

        private int _channel;

        private int _initPosition;

         private int _currentPosition;

        private string _goods;

        private List<string> _crews;

        private int  _allowedCrews;

        public Ship(string goods, int id, int channel, int initPosition)
        {
            _id = id;
            _goods = goods;
            _crews = new List<string>();
            _allowedCrews = 3;
        }

        public void SetInitPostion(int channel, int initPosition)
        {
            _initPosition= initPosition;
            _currentPosition = initPosition;
            _channel= channel;
        }

        public void Onboarding(string people)
        {
            if(_allowedCrews > _crews.Count)
                _crews.Add(people);
        }

        public bool GoAhead(int steps)
        {
            if(steps < 0)
                return false;
            
            _currentPosition = _currentPosition + steps;
            return true;
        }

        public bool Goback(int steps)
        {
            if(steps < 0)
                return false;

            if(steps > _currentPosition)
                return false;
            
            _currentPosition = _currentPosition - steps;
            return true;
        }
    }
}
