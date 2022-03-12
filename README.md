# Hyper Metroid Item Randomizer
Command Line Interface (CLI) edition fork by strotlog

Should work on various platforms including Linux and macOS!

## How to use CLI

Prerequisite 1: Install the .NET 6 SDK
Get from [dot.net/download](https://dot.net/download) and install

Prerequisite 2: Generate the base rando ROM:
1. `git clone https://github.com/strotlog/HyperMetroidRandomizerCLI`
2. Copy your unheadered, legal backup of Super Metroid to 'HyperMetroidRandomizerCLI/Hyper\_Metroid\_Rando\_Base\_ROM.sfc'
3. Download the latest unheadered [Hyper Metroid](https://metroidconstruction.com/hack.php?id=294) ips file (as of this writing, 1.0)
4. Extract the ips file from the rar file using a local tool or [extract.me](https://extract.me)
5. Apply the ips using Lunar IPS or a [Web ROM patcher](https://www.marcrobledo.com/RomPatcher.js/). Overwrite 'Hyper\_Metroid\_Rando\_Base\_ROM.sfc' with the outcome.
6. Apply 'PatchesCombined.ips', which was cloned from git, in the same way as step 5, overwriting the ROM.
7. Apply '', which was cloned from git, in the same way as step 5, overwriting the ROM.

The resulting checksum should be:

    $ shasum ./Hyper_Metroid_Rando_Base_ROM.sfc
    a033798b072c61ab55c32ecd0082652fa1a2f345  ./Hyper_Metroid_Rando_Base_ROM.sfc

Then to generate a randomized ROM,

    dotnet run -- --difficulty Casual

difficulty can be Casual, Veteran, Masochist, or Max (Max is experimental, appeared to be commented out in the original rando)

Original repo: [Hyper Metroid Item Randomizer by Galamoz](https://github.com/Galamoz/HyperMetroidRandomizer)

Original readme follows:

--------------

#### Hyper Metroid Randomizer Resources
##### Full game map reference with item names: https://i.imgur.com/ub7CYrA.png

###### Important technique to know for Hyper Metroid randomizers: Angle Down (L by default) + Down while midair to instant morphball.

#### Rules:

      Unlock the 15 Gates to access Tourian and defeat Mother Brain
      Level design modified to prevent morph locks and increase item variety
      Walljumping is required
      Tourian Item may only be obtained after Baby Metroid trigger
     
      
#### Casual Difficulty

      All 100 Items are included
      Varia Suit does not spawn in Norfair / Lower Norfair
      Gravity Suit does not spawn in Maridia / Maridia Depths / Wrecked Ship (past Phantoon)
      Morphing Ball may only spawn in Crateria
      Better distribution on Energy Tanks to assist casual play
      Infinite Bomb Jump is not required (more frequent early space jump spawns)

#### Veteran Difficulty

      All 100 Items are included
      Experimental Difficulty:
            Gravity Suit may spawn wherever possible
            Varia Suit may not spawn in Lower Nofair
            Certain item combinations for hellruns / gravity suit hellruns may not be possible.
            Certain deep suitless underwater sections may not be possible without High Jump Boots and Springball.
            Morphing Ball may spawn in both Norfair and Crateria.
      Different algorithm for increased randomization
      Decreased frequency of Energy Tanks
      IBJ, midair springball jump, and other advanced techniques are required
      
----------------------------------------------  

An Item Randomizer program for the Super Metroid Romhack called Hyper Metroid.  
It's a fork from Dessy's original Super Metroid Randomizer program, that can be found here: https://github.com/Dessyreqt/smrandomizer
# HUGE THANKS TO DESSY, YOU ARE AWESOME

###### Other Super Metroid Randomizer Links:
###### Total's Item Randomizer for the original Super Metroid: https://itemrando.supermetroid.run/
###### Total's Super Metroid and A Link to the Past Crossover Item Randomizer: https://alttsm.speedga.me/
###### Super Metroid Project Base Item Randomizer: [https://github.com/Galamoz/ProjectBaseRandomizer/blob/master/README.md](https://github.com/Galamoz/ProjectBaseRandomizer/blob/master/README.md)
----------------------------------------------



## Hyper Metroid Item Randomizer Changelog
##### For more information on gameplay changes from the original Super Metroid [check it out here](http://www.begrimed.com/pb/pb_info.html)

v 1.10 

    Veteran Difficulty has been added.
    Casual Difficulty - Adjusted Energy Tank frequency.
    Fixed a bug where collecting Morphing Ball would sometimes give Spring Ball instead.
        
    
v 1.00

    Public.
    Casual Difficulty has been added.
    Changes the level design of Hyper Metroid. Preventing softlocks due to item randomization and increasing item variety. 
    All 100 Items are available in Casual difficulty. 
    Morph Locks have been removed from the game. (For better or for worse.)
    Fixed a softlock involving Bomb Torizo and Power Bombs.
    Ceres has been removed.
    Grey Doors at X-Ray and Charge Beam rooms have been adjusted.
    Item in Tourian can only be obtained before the Mother Brain.
    
