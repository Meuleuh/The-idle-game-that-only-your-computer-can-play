using System.Collections.Generic;

namespace The_idle_game_that_only_your_computer_can_play
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
        static Ressource Wooden_Small_House_Foundation = new Ressource(
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
            dependency: new List<(Ressource, double)> { (Wooden_Small_House_Foundation, 1), (Wooden_Small_House_Roof, 1), (Wooden_Plank, 250) }
            );

        //21 : Wooden Medium House Foundation
        static Ressource Wooden_Medium_House_Foundation = new Ressource(
            name: "Wooden Medium House Foundation",
            basePrice: 200000,
            amountPerLevel: 1,
            sellPrice: 20000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 25), (Wooden_Beam, 56) }
            );

        //22 : Wooden Medium House Roof
        static Ressource Wooden_Medium_House_Roof = new Ressource(
            name: "Wooden Medium House Roof",
            basePrice: 200000,
            amountPerLevel: 1,
            sellPrice: 20000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 1), (Wooden_Beam, 32) }
            );

        //23 : Wooden Medium House
        static Ressource Wooden_Medium_House = new Ressource(
            name: "Wooden Medium House",
            basePrice: 500000,
            amountPerLevel: 1,
            sellPrice: 50000,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 400), (Wooden_Medium_House_Foundation, 1), (Wooden_Medium_House_Roof, 1) }
            );

        //24 : Wooden Big House Foundation
        static Ressource Wooden_Big_House_Foundation = new Ressource(
            name: "Wooden Big House Foundation",
            basePrice: 400000,
            amountPerLevel: 1,
            sellPrice: 40000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 36), (Wooden_Beam, 110)}
            );

        //25 : Wooden Big House Second Floor
        static Ressource Wooden_Big_House_Second_Floor = new Ressource(
            name: "Wooden Big House Second Floor",
            basePrice: 400000,
            amountPerLevel: 1,
            sellPrice: 40000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 36), (Wooden_Beam, 110) }
            );

        //26 : Wooden Big House Roof
        static Ressource Wooden_Big_House_Roof = new Ressource(
            name: "Wooden Big House Roof",
            basePrice: 400000,
            amountPerLevel: 1,
            sellPrice: 40000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 4), (Wooden_Beam, 48) }
            );

        //27 : Wooden Big House
        static Ressource Wooden_Big_House = new Ressource(
            name: "Wooden Big House",
            basePrice: 1000000,
            amountPerLevel: 1,
            sellPrice: 100000,
            dependency: new List<(Ressource, double)> { (Wooden_Big_House_Foundation, 1), (Wooden_Big_House_Roof, 1), (Wooden_Big_House_Second_Floor, 1), (Wooden_Plank, 1125) }
            );

        //28 : Wooden Door
        static Ressource Wooden_Door = new Ressource(
            name: "Wooden Door",
            basePrice: 60,
            amountPerLevel: 1,
            sellPrice: 18,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 6) }
            );

        //29 : Wooden Bowl
        static Ressource Wooden_Bowl = new Ressource(
            name: "Wooden Bowl",
            basePrice: 7,
            amountPerLevel: 1,
            sellPrice: 3,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1) }
            );

        //30 : Wooden Fork
        static Ressource Wooden_Fork = new Ressource(
            name: "Wooden Fork",
            basePrice: 25,
            amountPerLevel: 10,
            sellPrice: 1,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1) }
            );

        //31 : Wooden Knife
        static Ressource Wooden_Knife = new Ressource(
            name: "Wooden Knife",
            basePrice: 25,
            amountPerLevel: 10,
            sellPrice: 1,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1) }
            );

        //32 : Wooden Spoon
        static Ressource Wooden_Spoon = new Ressource(
            name: "Wooden Spoon",
            basePrice: 25,
            amountPerLevel: 10,
            sellPrice: 1,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1) }
            );

        //33 : Wooden Hoe
        static Ressource Wooden_Hoe = new Ressource(
            name: "Wooden Hoe",
            basePrice: 50,
            amountPerLevel: 1,
            sellPrice: 10,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 2) }
            );

        //34 : Wooden Shovel
        static Ressource Wooden_Shovel = new Ressource(
            name: "Wooden Shovel",
            basePrice: 50,
            amountPerLevel: 1,
            sellPrice: 10,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 2) }
            );

        //35 : Wooden Toy
        static Ressource Wooden_Toy = new Ressource(
            name: "Wooden Toy",
            basePrice: 100,
            amountPerLevel: 1,
            sellPrice: 20,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1) }
            );

        //36 : Paper
        static Ressource Paper = new Ressource(
            name: "Paper",
            basePrice: 2500,
            amountPerLevel: 100,
            sellPrice: 1,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1) }
            );

        //37 : Wooden Frame
        static Ressource Wooden_Frame = new Ressource(
            name: "Wooden Frame",
            basePrice: 500,
            amountPerLevel: 1,
            sellPrice: 8,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 2) }
            );

        //38 : Wooden Library
        static Ressource Wooden_Library = new Ressource(
            name: "Wooden Library",
            basePrice: 100,
            amountPerLevel: 1,
            sellPrice: 30,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 10) }
            );

        //39 : Feather
        static Ressource Feather = new Ressource(
            name: "Feather",
            basePrice: 100,
            amountPerLevel: 10,
            sellPrice: 1,
            dependency: null
            );

        //40 : Wooden Arrow
        static Ressource Wooden_Arrow = new Ressource(
            name: "Wooden Arrow",
            basePrice: 200,
            amountPerLevel: 100,
            sellPrice: 2,
            dependency: new List<(Ressource, double)> { (Wooden_Plank, 1), (Feather, 100) }
            );

        //41 : Stone
        static Ressource Stone = new Ressource(
            name: "Stone",
            basePrice: 20,
            amountPerLevel: 1,
            sellPrice: 2,
            dependency: null
            );

        //42 : Cutted Stone
        static Ressource Cutted_Stone = new Ressource(
            name: "Cutted Stone",
            basePrice: 50,
            amountPerLevel: 1,
            sellPrice: 3,
            dependency: new List<(Ressource, double)> { (Stone, 1) }
            );

        //43 : Stone Rod
        static Ressource Stone_Rod = new Ressource(
            name: "Stone Rod",
            basePrice: 50,
            amountPerLevel: 1,
            sellPrice: 3,
            dependency: new List<(Ressource, double)> { (Stone, 1)}
            );

        //44 : Stone Pickaxe Head
        static Ressource Stone_Pickaxe_Head = new Ressource(
            name: "Stone Pickaxe Head",
            basePrice: 75,
            amountPerLevel: 1,
            sellPrice: 5,
            dependency: new List<(Ressource, double)> { (Stone, 2) }
            );

        //45 : Stone Shovel Head
        static Ressource Stone_Shovel_Head = new Ressource(
            name: "Stone Shovel Head",
            basePrice: 75,
            amountPerLevel: 1,
            sellPrice: 5,
            dependency: new List<(Ressource, double)> { (Stone, 2) }
            );

        //46 : Stone Hoe Head
        static Ressource Stone_Hoe_Head = new Ressource(
            name: "Stone Hoe Head",
            basePrice: 75,
            amountPerLevel: 1,
            sellPrice: 5,
            dependency: new List<(Ressource, double)> { (Stone, 2) }
            );

        //47 : Stone Sword Blade
        static Ressource Stone_Sword_Blade = new Ressource(
            name: "Stone Sword Blade",
            basePrice: 75,
            amountPerLevel: 1,
            sellPrice: 5,
            dependency: new List<(Ressource, double)> { (Stone, 2) }
            );

        //48 : Stone Long Sword Blade
        static Ressource Stone_Long_Sword_Blade = new Ressource(
            name: "Stone Long Sword Blade",
            basePrice: 100,
            amountPerLevel: 1,
            sellPrice: 6,
            dependency: new List<(Ressource, double)> { (Stone, 3) }
            );

        //49 : Stone Small House Foundation
        static Ressource Stone_Small_House_Foundation = new Ressource(
            name: "Stone Small House Foundation",
            basePrice: 200000,
            amountPerLevel: 1,
            sellPrice: 15000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 64), (Wooden_Beam, 30) }
            );

        //50 : Stone Small House Roof
        static Ressource Stone_Small_House_Roof = new Ressource(
            name: "Stone Small House Roof",
            basePrice: 100000,
            amountPerLevel: 1,
            sellPrice: 10000,
            dependency: new List<(Ressource, double)> { (Wooden_Beam, 22) }
            );

        //51 : Stone Small House
        static Ressource Stone_Small_House = new Ressource(
            name: "Stone Small House",
            basePrice: 500000,
            amountPerLevel: 1,
            sellPrice: 50000,
            dependency: new List<(Ressource, double)> { (Stone_Small_House_Foundation, 1), (Stone_Small_House_Roof, 1), (Wooden_Plank, 100), (Cutted_Stone, 150) }
            );

        //52 : Stone Medium House Foundation
        static Ressource Stone_Medium_House_Foundation = new Ressource(
            name: "Stone Medium House Foundation",
            basePrice: 400000,
            amountPerLevel: 1,
            sellPrice: 30000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 100), (Wooden_Beam, 56) }
            );

        //53 : Stone Medium House Roof
        static Ressource Stone_Medium_House_Roof = new Ressource(
            name: "Stone Medium House Roof",
            basePrice: 210000,
            amountPerLevel: 1,
            sellPrice: 21000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 4), (Wooden_Beam, 32) }
            );

        //54 : Stone Medium House
        static Ressource Stone_Medium_House = new Ressource(
            name: "Stone Medium House",
            basePrice: 1000000,
            amountPerLevel: 1,
            sellPrice: 100000,
            dependency: new List<(Ressource, double)> { (Stone_Medium_House_Foundation, 1), (Stone_Medium_House_Roof, 1), (Wooden_Plank, 160), (Cutted_Stone, 240) }
            );

        //55 : Stone Big House Foundation
        static Ressource Stone_Big_House_Foundation = new Ressource(
            name: "Stone Big House Foundation",
            basePrice: 800000,
            amountPerLevel: 1,
            sellPrice: 60000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 144), (Wooden_Beam, 110) }
            );

        //56 : Stone Big House Second Floor
        static Ressource Stone_Big_House_Second_Floor = new Ressource(
            name: "Stone Big House Second Floor",
            basePrice: 800000,
            amountPerLevel: 1,
            sellPrice: 60000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 144), (Wooden_Beam, 110) }
            );

        //57 : Stone Big House Roof
        static Ressource Stone_Big_House_Roof = new Ressource(
            name: "Stone Big House Roof",
            basePrice: 420000,
            amountPerLevel: 1,
            sellPrice: 42000,
            dependency: new List<(Ressource, double)> { (Wooden_Pillar, 16), (Wooden_Beam, 48) }
            );

        //58 : Stone Big House
        static Ressource Stone_Big_House = new Ressource(
            name: "Stone Big House",
            basePrice: 2000000,
            amountPerLevel: 1,
            sellPrice: 100000,
            dependency: new List<(Ressource, double)> { (Stone_Big_House_Foundation, 1), (Stone_Big_House_Roof, 1), (Stone_Big_House_Second_Floor, 1), (Cutted_Stone, 675), (Wooden_Plank, 450) }
            );

        //59 : Stone Maul
        static Ressource Stone_Maul = new Ressource(
            name: "Stone Maul",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 9,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone, 1) }
            );

        //60 : Stone Mace
        static Ressource Stone_Mace = new Ressource(
            name: "Stone Mace",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 9,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone, 1) }
            );

        //61 : Stone Spear
        static Ressource Stone_Spear = new Ressource(
            name: "Stone Spear",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 9,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone, 1) }
            );

        //62 : Wooden Spear
        static Ressource Wooden_Spear = new Ressource(
            name: "Wooden Spear",
            basePrice: 20,
            amountPerLevel: 1,
            sellPrice: 2,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1) }
            );

        //63 : Stone Mortar And Pestle
        static Ressource Stone_Mortar_And_Pestle = new Ressource(
            name: "Stone Mortar And Pestle",
            basePrice: 40,
            amountPerLevel: 1,
            sellPrice: 4,
            dependency: new List<(Ressource, double)> { (Stone, 1) }
            );

        //64 : Stone Pickaxe
        static Ressource Stone_Pickaxe = new Ressource(
            name: "Stone Pickaxe",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 15,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone_Pickaxe_Head, 1) }
            );

        //65 : Stone Shovel
        static Ressource Stone_Shovel = new Ressource(
            name: "Stone Shovel",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 15,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone_Shovel_Head, 1) }
            );

        //66 : Stone Hoe
        static Ressource Stone_Hoe = new Ressource(
            name: "Stone Hoe",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 15,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone_Hoe_Head, 1) }
            );

        //67 : Stone Sword
        static Ressource Stone_Sword = new Ressource(
            name: "Stone Sword",
            basePrice: 150,
            amountPerLevel: 1,
            sellPrice: 15,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone_Sword_Blade, 1) }
            );

        //68 : Stone Long Sword
        static Ressource Stone_Long_Sword = new Ressource(
            name: "Stone Long Sword",
            basePrice: 200,
            amountPerLevel: 1,
            sellPrice: 20,
            dependency: new List<(Ressource, double)> { (Wood_Log, 1), (Stone_Long_Sword_Blade, 1) }
            );

        //More to come...
    }
}