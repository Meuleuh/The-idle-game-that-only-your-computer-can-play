###### *This file is to be red in pair with the "ressource level up" sheet...*

## What should be needed upon creating ressources ?

In the "ressource level up" sheet, we covered how to level up our ressource production.
We talked about the fact that leveling up could require tools *or not*, and could require money *or not*...
The thing is that, before moving on, we must define what is also required upon producing the ressources.

First of all, as stated in the "ressource level up" document, tools could be used only upon leveling up ressource production or could be needed upon every ressource generation.
This statement is really important since it will alter how fast money can be produced and which dependencies will need to be met before progressing any further...

**If we decide to only sacrifice tools upon leveling up,** then the script would be a bit more complicated *but who cares about that detail ?*
Also, this would slow down money production **a little bit** only upon the iterations where upgrades are made.

**If we decide to sacrifice tools at every iteration,** we would need to implement the fact that tools can comes up in many differents tiers (such as wooden axe, iron axe, steel axe, etc...)
That *very little* detail would means that in the script, an auto-tool tier selector would also be needed, selecting the worthless of all that are accessible for producing that other ressource.
The only thing tho' is that even if it may seem easier to make, it may end up in the game producing an infinite loop of wood and wooden axe production leveling up, since both would be needed to produce each other, preventing the progression of the game...
*But seriously, who cares about those coding details ? I do, for sure, but nobody else, am I right ?*
