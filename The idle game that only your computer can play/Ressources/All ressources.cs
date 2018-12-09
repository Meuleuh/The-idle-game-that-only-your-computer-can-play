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
        //No objects to create, this line is only used to get the "none" dependency possibility in the Access database

        //2 : Wood Log
        static Ressource Wood_Log = new Ressource(
            name: "Wood Log",
            basePrice: 5,
            amountPerLevel: 1,
            sellPrice: 1,
            dependency: null
            );

        //3 : Wooden Plank
        static Ressource Wooden_Plank = new Ressource(
            name: "Wooden Plank",
            basePrice: 10,
            amountPerLevel: 1,
            sellPrice: 2,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1) }
            );

        //4 : Wooden Pratice Sword
        static Ressource Wooden_Practice_Sword = new Ressource(
            name: "Wooden Practice Sword",
            basePrice: 20,
            amountPerLevel: 1,
            sellPrice: 5,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1) }
            );

        //5 : Wooden Shield
        static Ressource Wooden_Shield = new Ressource(
            name: "Wooden Shield",
            basePrice: 30,
            amountPerLevel: 1,
            sellPrice: 8,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 2) }
            );

        //6 : Wooden Long Sword
        static Ressource Wooden_Long_Sword = new Ressource(
            name: "Wooden Long Sword",
            basePrice: 40,
            amountPerLevel: 1,
            sellPrice: 10,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 2) }
            );

        //7 : Wooden Small Chair
        static Ressource Wooden_Small_Chair = new Ressource(
            name: "Wooden Small Chair",
            basePrice: 45,
            amountPerLevel: 1,
            sellPrice: 12,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 3) }
            );

        //8 : Wooden Chair
        static Ressource Wooden_Chair = new Ressource(
            name: "Wooden Chair",
            basePrice: 55,
            amountPerLevel: 1,
            sellPrice: 15,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 4) }
            );

        //9 : Wooden Tall Chair
        static Ressource Wooden_Tall_Chair = new Ressource(
            name: "Wooden Tall Chair",
            basePrice: 65,
            amountPerLevel: 1,
            sellPrice: 17,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 5) }
            );

        //10 : Wooden Small Table
        static Ressource Wooden_Small_Table = new Ressource(
            name: "Wooden Small Table",
            basePrice: 57,
            amountPerLevel: 1,
            sellPrice: 16,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 4) }
            );

        //11 : Wooden Table
        static Ressource Wooden_Table = new Ressource(
            name: "Wooden Table",
            basePrice: 75,
            amountPerLevel: 1,
            sellPrice: 22,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 7) }
            );

        //12 : Wooden Family Table
        static Ressource Wooden_Family_Table = new Ressource(
            name: "Wooden Family Table",
            basePrice: 100,
            amountPerLevel: 1,
            sellPrice: 30,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 10) }
            );

        //13 : Wooden Long Table
        static Ressource Wooden_Long_Table = new Ressource(
            name: "Wooden Long Table",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 50,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 20) }
            );

        //14 : Wooden Dresser
        static Ressource Wooden_Dresser = new Ressource(
            name: "Wooden Dresser",
            basePrice: 60,
            amountPerLevel: 1,
            sellPrice: 18,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 4) }
            );

        //15 : Wooden Wardrobe
        static Ressource Wooden_Wardrobe = new Ressource(
            name: "Wooden Wardrobe",
            basePrice: 110,
            amountPerLevel: 1,
            sellPrice: 40,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 8) }
            );

        //16 : Wooden Pillar
        static Ressource Wooden_Pillar = new Ressource(
            name: "Wooden Pillar",
            basePrice: 25,
            amountPerLevel: 1,
            sellPrice: 6,
            dependency: new List<(Ressource, double)> { (Wood_Log, 2) }
            );

        //17 : Wooden Beam
        static Ressource Wooden_Beam = new Ressource(
            name: "Wooden Beam",
            basePrice: 25,
            amountPerLevel: 1,
            sellPrice: 6,
            dependency: new List<(Ressource, double)> { (Wood_Log, 2) }
            );

        //18 : Wooden Small House Foundations
        static Ressource Wooden_Small_House_Foundations = new Ressource(
            name: "Wooden Small House Foundation",
            basePrice: 100000,
            amountPerLevel: 1,
            sellPrice: 10000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 16), (Wooden_Beam, 30) }
            );

        //19 : Wooden Small House Roof
        static Ressource Wooden_Small_House_Roof = new Ressource(
            name: "Wooden Small House Roof",
            basePrice: 100000,
            amountPerLevel: 1,
            sellPrice: 10000,
            dependency: new List<(Ressource, double)> { (Wooden_Beam, 22) }
            );

        //20 : Wooden Small House
        static Ressource Wooden_Small_House = new Ressource(
            name: "Wooden Small House",
            basePrice: 250000,
            amountPerLevel: 1,
            sellPrice: 25000,
            dependency: new List<(Ressource, double)> { (Wooden_Small_House_Foundations, 1), (Wooden_Small_House_Roof, 1), (Wooden_Plank, 250) }
            );

        //21 : Wooden Medium House Foundation

        //22 : Wooden Medium House Roof

        //23 : Wooden Medium House

        //24 : Wooden Big House Foundation

        //25 : Wooden Big House Second Floor
        
        //26 : Wooden Big House Roof

        //27 : Wooden Big House

        //28 : Wooden Door

        //29 : Wooden Bowl

        //30 : Wooden Fork
        
        //31 : Wooden Knife

        //32 : Wooden Spoon

        //33 : Wooden Hoe

        //34 : Wooden Shovel

        //35 : Wooden Toy

        //36 : Paper

        //37 : Wooden Fram

        //38 : Wooden Library

        //39 : Feather

        //40 : Wooden Arrow
    }
}