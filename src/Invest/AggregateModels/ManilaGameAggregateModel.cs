using System;
using System.Collections.Generic;
using Logistics;
using Stocks;

namespace Invest.AggregateModels
{
    public class ManilaGameAggregateModel
    {
        public List<string> _players;

        public Market _stockMarket;

        public List<DynamicInvestmentItem> _investItems;

        public ManilaGameAggregateModel(List<string> players)
        {
            _players = players;
            _stockMarket = new Market();    
            _investItems = new List<DynamicInvestmentItem>();        
        }

        private void InitPortInvestItems()
        {
            _investItems.Add(new DynamicInvestmentItem(6,new List<Share>(){new Share(4)}));
            _investItems.Add(new DynamicInvestmentItem(8,new List<Share>(){new Share(3)}));
            _investItems.Add(new DynamicInvestmentItem(15,new List<Share>(){new Share(2)}));
        }

        private void InitPairShopInvestItems()
        {
            _investItems.Add(new DynamicInvestmentItem(6,new List<Share>(){new Share(4)}));
            _investItems.Add(new DynamicInvestmentItem(8,new List<Share>(){new Share(3)}));
            _investItems.Add(new DynamicInvestmentItem(15,new List<Share>(){new Share(2)}));
        }

        private void InitPlantGoodsInvestItems()
        {
            _investItems.Add(new DynamicInvestmentItem(18,new List<Share>(){new Share(1), new Share(2), new Share(3)}));
            _investItems.Add(new DynamicInvestmentItem(32,new List<Share>(){new Share(3), new Share(4), new Share(5)}));
            _investItems.Add(new DynamicInvestmentItem(24,new List<Share>(){new Share(2), new Share(3), new Share(4)}));
            _investItems.Add(new DynamicInvestmentItem(36,new List<Share>(){new Share(3), new Share(4), new Share(4),new Share(5)}));
        }

        private void InitActivesInvestItems()
        {
            NormalInvestmentActive<Ship> shipMoveOneStep = new NormalInvestmentActive<Ship>(3, ShipMoveOneStep);
            NormalInvestmentActive<Ship> shipMoveTwoStep = new NormalInvestmentActive<Ship>(5, ShipMoveTwoStep);        
        }

        private void ShipMoveOneStep(Ship ship)
        {
           ship.GoAhead(1);  
        }

        private void ShipMoveTwoStep(Ship ship)
        {
           ship.GoAhead(2);  
        }

        // private void ShipMoveOneStep(Ship ship, string operation = "go")
        // {
        //     operation == "go" ?  ship.GoAhead(1):  ship.Goback(1);         
        // }

        // private void ShipMoveTwoStep(Ship ship, string operation = "go")
        // {
        //     operation == "go" ?  ship.GoAhead(2):  ship.Goback(2);   
        // }

        public bool IsGameTerminal() => _stockMarket.ExistedStockPriceAchived30();
    }

}
