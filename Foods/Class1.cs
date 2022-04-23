﻿using System;

namespace Logistics
{
    public class Foods
    {
        public string _name;

        public string _describe;

        public 
    }

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

        public void SetInitPostion(int channel, int initPosition)
        {
            _initPosition= initPosition;
            _channel= channel;
        }

        public void Onboarding(string people)
        {
            if(_allowedCrews > _crews.count())
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

    public class Investment 
    {
        private 
        public class 
    }

    public class InvestmentItem
    {
        private int _earnings;

        private int _cost;

        private string _beneficiary;

        public InvestmentItem(int earnings, int cost)
        {
            _earnings = earnings;  
            _cost = cost;
        }
    }

    public class DynamicInvestmentItem
    {
        private int _totalEarnings;

        private int _cost;

        private string _beneficiary;

        public InvestmentItem(int earnings, int cost)
        {
            _earnings = earnings;  
            _cost = cost;
        }

    }
}