using System.Collections.Generic;

namespace The_idle_game_that_only_your_computer_can_play.Text_Documents
{
    public class Ressource
    {
        readonly string name;
        long level;
        readonly long basePrice;
        readonly long amountPerLevel;
        readonly long sellPrice;
        long amountProduced;
        readonly List<(Ressource, long)> dependency;
        long nextUpgradePrice;
    }
}
