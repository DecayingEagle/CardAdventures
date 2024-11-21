# Card game roguelike - Design doc

## Overview
This game is will be a dungeon crawler card game roguelike with turn based 
(Slay the Spire inspired) card battle.

## Game flow
1. Player starts in the starting room where they choose a
   [class](#decks-and-classes) that starts
   with a predefined [deck](#decks-and-classes). The starting room is 
   already in the 
   randomly generated dungeon (discussed futher in 
   [dungeon generation](#dungeon-generation)).
2. Upon entering a [room](#rooms), the enemies will spawn (all card based) and 
   the 
   enemies with different movement pattern for each one will move towards 
   the player. 
3. The player has an opportunity to do a first attack by throwing a card. 
   This attack will deal some default damage to the enemy that can be 
   upgraded with the items that the player can find in the dungeon. If there 
   are multiple enemies in the room only one will be attacked but this also 
   can be changed with items.
4. Player engages the battle (discussed in the [battle system](#battle-system) 
   section).
5. After the battle the player is rewarded with a selection of card to add to 
   their deck and some gold.
6. The room is cleared and the player can move to the next room or try to 
   find secrets in the current room i.e. special rocks that can be destroyed 
   which give hearts or gold or different items (to be decided), or a hidden 
   room that can be found by destroying a wall. These can spawn rarely.
7. The player can also find a shop room where they can buy cards, items from 
   the shop [pool](#item-pools), or sometimes upgrade their cards with 
   [editions](#card-editions) of the card (this might be either that a NCP 
   can randomly spawn or that that will be either a special version of the 
   shop or a different room that can sometimes spawn).
8. Eventually the player will reach the boss room where they will fight the 
   boss. The boss will have a different movement pattern and will have 
   different abilities than the normal enemies. The boss will also have a 
   special card that will be added to the player's deck if they defeat the 
   boss.
9. After defeating the boss a special boss shop will spawn where the player 
   can buy special items that can only be bought in the boss shop.
10. The player will then move to the next floor where the enemies will be 
    harder and the player will have to fight more enemies to reach the boss 
    room.
11. The player will continue to do this until they die or reach the final 
    boss.
12. The final boss will be one of four bosses Ace, King, Queen, and Jack 
    (might be renamed later with a cooler name). Each boss will have a 
    different movement pattern and abilities. The final boss will also have 
    a special card that will be added to the player's deck if they defeat 
    the boss.

## Battle system
The battle system will be turn based where the player and the
[enemies](#enemies) will fight until one of them dies. The player will have 
a deck of cards where they draw a hand of a size that starts at (a number to 
be decided) and can be upgraded with [items](#items). The player will draw 
a hand of cards and can play a set number of cards per turn (to be decided) 
that also can be upgraded. The player can play different hands that change 
the [damage calculation](#damage-calculation) with cards that have different 
[editions](#card-editions) that give different effects. The player can also 
play will have also the ability to discard (a limited upgradable amount) 
cards that they don't want to play. The player will be able to choose which 
enemy to attack if there are multiple.<br>
After the damage is calculated the enemies will be damaged, effects will be 
applied and the enemies will have their turn to attack. 

## Damage calculation
As mentioned in the [battle system](#battle-system) section damage will be 
dependent on the cards that the player plays and on the
[poker hand](#poker-hands). Unlike in Balatro where you can affect both the 
chips and multiplier, in this game almost all damage effects will only give 
you a multiplier except cards or items that can replay a card although most 
of these items will not replay the card effect but only the base card damage.

### Poker hands
* x of a kind
* Royal flush
* Straight flush
* Four of a kind
* Full house
* Flush
* Straight
* Three of a kind
* Two pair
* One pair
* High card
<br>Mult on these will be decided later.

## Item pools
Each type of [room](#rooms) will have its own pool of items. These pools can 
overlap but the items that can be found in the pool will be different.

## Items
### Passive items - battle items
### Passive items - non-battle items
* Pot of Greed
  * Get x (to be decided) cards from a selection
### Active items

## Card editions
* One shot (_rare_)
  * The card is removed from the deck after being played (doesn't work on 
    bosses)
* Mirrored
  * The card is played twice
* Holographic
  * Gives mult to the card
* Mending
  * Heals the player for x (to be decided) amount
* Sour
  * Poisons the enemy for x (to be decided) amount of turns
  * (side note: will have a slimy design and the card will look like it's 
    melting from acid)
* More to be added

## Decks and classes
Decks and classes will be predefined and will be able to be chosen separately.
### Decks
To be decided
### Classes
To be decided

## Rooms
* Starting room
  * The room where the player chooses their class and starts the game
* Normal room
  * The room where the player fights enemies
* Shop room
  * The room where the player can buy items and cards
* Treasure room
  * The room where the player can find items and cards
* Secret room
  * The room where the player can find secrets
* Boss room
  * The room where the player fights the boss
* Boss shop
  * The room where the player can buy special items that can only be bought 
    in the boss shop
More to be added

## Dungeon generation
The dungeon will be randomly generated from a seed that can be set by the 
user although this won't grant achievements nor unlocks. The dungeon 
generation will be inspired by The Binding of Isaac. On each floor there 
will always be a starting room, a boss room, a shop room and a treasure room. 
The rest of the rooms will be normal rooms.

## Enemies
To be decided

## Bosses
To be decided

## Easter eggs
* Faker mode
  * Instead of card battle you have to juggle between 4 different games 
    (to be decided) that will be randomly selected, but u get a boost for 
    something (to be decided).
