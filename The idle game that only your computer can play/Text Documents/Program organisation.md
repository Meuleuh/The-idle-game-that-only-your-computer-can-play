Calling every function (They might get subdivided after, the "function" like I call them right now is more step of the program. It doesn't include the plan of including multiple console since I don't wanna work on it right now)

#### Function 1: Initialisation

The statup menu where you can select if you want to create a new game or load an existing one game

if (Create) {

Display the two game options: Clockspeed or timer-based (Clockspeed = no delay between production, the computer speed is the only limit | Timer-based = Production every seconds

Ask the name of the save file

Create the save file (A real external file with a .save extension, if possible, to avoid people manipulation)

Upon creating a new game, the base money will be of 5$ so that the Wood Log Level 1 can be bought

}

else if (Load) {

Display the list of avaible saves

Querry the user for the selected save

Load all the data of the selected save file

}


#### Function 2: Execution

(Have a look on the ressources file if you want the full list + Base price + Dependencies)

Price function (Rounded Up): [Next Level Price] = [Base Price] × 1,05 ^ [Actual Level]

As exemple of the function, let's use Wood Log

**Level 1:**

Level 1 Price = 5$ × 1,05⁰

Level 1 Price = 5$ × 1

Level 1 Price = 5$

**Level 2:**

Level 2 Price = 5$ × 1,05¹

Level 2 Price = 5$ × 1,05

Level 2 Price = 5,25$

Level 2 Price = 6$

**Level 3**

Level 3 Price = 5$ × 1,05²

Level 3 Price = 5$ × 1,25

Level 3 Price = 5,5125$

Level 3 Price = 6 $

**Grid 1-10**

| Level | Price |
|:-----:|:-----:|
|   1   |  5 $  |
|   2   |  6 $  |
|   3   |  6 $  |
|   4   |  6 $  |
|   5   |  7 $  |
|   6   |  7 $  |
|   7   |  7 $  |
|   8   |  8 $  |
|   9   |  8 $  |
|   10  |  8 $  |

*I hope you understand now?*

The price is gonna be calculated every time an upgrade is bought or the save is loaded

Every time an item is bought, the price will be deducted from the remaining money *obviously*

An "algoritm" will take care of buying the cheapest thing, but won't buy something if it depencies cannot ensure his production!

The "algorithm" will repeat the "buy loop" until she cannot buy anything useful *remember the restriction of the previous line*

Every time something is bought, an line of text will appear on the log so that the player can see how it advance

When the other display console will be added, the number of "time something got producted" will be displayed so that stat should already be taken in the earliest version of the development

Depending on the gamemode of the save, the progression will be fater/slower!

On "clockspeed" mode, the game will be as fast as the computer can get so if the computer is powerful enough, it may reach iteraion 1000 in a blink of eyes *who knows, maybe it will reach iteration 10 000 or iteration 1 000 000 in a blink of eyes...*

On "timed" mode, the production will occur every second, even if the computer didn't had time to buy everything during that second! So the timer will be an side-process that won't wait for the upgrade "algorithm" to count down his seconds

An timer should then be configurated too...

Since every extra production will be sold at every iteration, we don't need to make variable to store their amount...

Still, some production may produce more than one item per iteration *Like if I want to make metal nails, it won't be an ratio of [1 metal bar = 1 nail]... If that would be the case, we could just say "screw logic and screw productivity!"*

#### Function 3: Saving

Every time *1 / 10 / 100 / 1000 (must be define to be as optimised as possible* iteration is made, the game will automaticly save in a file named the same way as the save.

In this save, those element should be included:
- **[Save name]** *safety measure, so that, maybe, if needed, an backup function could be added later*
- **[Save original version]** *It will be easier for people to declare retro-compatibility issue using that stat*
- **[Save latest version]** *If ever somebody give me his save so that I can fix an problem, but I release other version before working on it, it will make it easier for me to find what could have caused the problem... If you don't understand, don't worry, you don't need to...*
- **[Number of time the file got opened]** *Probably the only stat that will be modified upon opening the save*
- **[Number of time the game got saved]** *Yup, this stat too could be useful...*
- **[Number of iteration]** *Like I said at the end of Fuction 2*
- **[Money]** *Of course...*
- **[Every material actual level]** *Obviously*

*The way of storing those variable is still not defined! It could be an numerous variable type, since number are the only things stored here, but the string variable could avoid number overflow...*

With all those things said, you should get an good idea of how the code will be / is structured!
-