using System;
using System.Collections.Generic;
using The_idle_game_that_only_your_computer_can_play;

namespace The_idle_game_that_only_your_computer_can_play.Text_Documents
{
    public partial class TheGameItself
    {
        //Following the Access database file
        //ID : Name

        //1 : None
        //No objects to create, this line is only used to get the "no dependency" possibility in the Access database

        //2 : Wood Log
        static Ressource Wood_Log = new Ressource(
            name: "Wood Log",
            basePrice: 5,
            amountPerLevel: 1,
            sellPrice: 1,
            dependency: null
            );

        //3 : Wooden plank
        Ressource Wooden_Plank = new Ressource(
            name: "Wooden Plank",
            basePrice: 10,
            amountPerLevel: 1,
            sellPrice: 2,
            dependency: new List<(Ressource, double)> {(Wood_Log,1)}
            );

    }
}