using System;
using System.Collections.Generic;

namespace The_idle_game_that_only_your_computer_can_play
{
    public class Ressource
    {
        public string Name { get; }
        public double Level { get; set; } = 0;
        public double BasePrice { get; }
        public double AmountPerLevel { get; }
        public double SellPrice { get; }
        public double AmountProduced { get; set; } = 0;
        public List<(Ressource, double)> Dependency { get; } = new List<(Ressource, double)>{};
        public double NextUpgradePrice { get; set; }
        public Ressource(string name, double basePrice, double amountPerLevel, double sellPrice, List<(Ressource, double)> dependency)
        {
            Name = name;
            BasePrice = basePrice;
            AmountPerLevel = amountPerLevel;
            SellPrice = sellPrice;
            Dependency = dependency;
            UpdatePrice();
        }
        public void UpdatePrice()
        {
                NextUpgradePrice = BasePrice * Math.Pow(1.05, Level);
        }
    }
}
