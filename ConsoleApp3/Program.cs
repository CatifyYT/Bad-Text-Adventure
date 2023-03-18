// See https://aka.ms/new-console-template for more information
using System;
class Game
{
    static void Main(string[] args)
    {
        int health = 100;
        int gold = 0;
        int attack = 10;
        int defense = 5;
        int potions = 3;
        Console.WriteLine("Game By CatBit");
        Console.WriteLine("Welcome to the game! What is your name? Game By CatBit");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "! You are a brave adventurer on a quest to defeat the dragon and save the kingdom. You start your journey with " + health + " health, " + gold + " gold, " + attack + " attack, " + defense + " defense and " + potions + " potions.");

        while (true)
        {
            Console.WriteLine("You come across a fork in the road, which direction would you like to go? (Left, Right, Forward)");
            string direction = Console.ReadLine();

            if (direction == "Left")
            {
                Console.WriteLine("You have stumbled upon a small village. The villagers offer to sell you a sword for 10 gold. Do you want to buy it? (Yes or No)");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    if (gold >= 10)
                    {
                        gold -= 10;
                        attack += 5;
                        Console.WriteLine("You have successfully bought the sword! Your attack has increased to " + attack + " and you now have " + gold + " gold left.");
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough gold! You have " + gold + " gold left.");
                    }
                }
                else
                {
                    Console.WriteLine("You decided not to buy the sword. Your attack is still " + attack + ".");
                }
            }
            else if (direction == "Right")
            {
                Console.WriteLine("You have stumbled upon a dark cave. Do you want to enter? (Yes or No)");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    Console.WriteLine("You have entered the cave and encountered a goblin! You have to fight it.");
                    int goblinHealth = 50;
                    while (goblinHealth > 0)
                    {
                        goblinHealth -= attack;
                        health -= 5;
                        Console.WriteLine("You attacked the goblin and did " + attack + " damage. The goblin has " + goblinHealth + " health left. The goblin attacked you and you lost 5 health. You now have " + health + " health left.");
                        if (health <= 0)
                        {
                            Console.WriteLine("You have died! Thanks for playing.");
                            Console.ReadKey();
                            return;
                        }
                    }
                    Console.WriteLine("You have defeated the goblin! You found 10 gold and a health potion. Your health is now " + health + " and your gold is " + (gold + 10) + ".");
                    gold += 10;
                    potions++;
                }
                else
                {
                    Console.WriteLine("You decided not to enter the cave.");
                }
            }
            else if (direction == "Forward")
            {




