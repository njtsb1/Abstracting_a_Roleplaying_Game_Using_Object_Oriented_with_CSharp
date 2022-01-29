using System;
using Abstraction_Game_RPG_in_C.src.Entities;

namespace Abstraction_Game_RPG_in_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation of heroes with their characteristics (instantiating an object)
            Warrior flame_swordsman = new Warrior("Flame Swordsman", 92, "Warrior");
            Warrior black_luster_soldier = new Warrior("Black Luster Soldier", 94, "Warrior"); 
            Knight gaia_fierce = new Knight("Gaia Fierce", 99, "Knight");
            Knight magro_nego = new Knight("Magro Nego", 100, "Knight");
            Ninja senior_silver = new Ninja("Senior Silver", 96, "Ninja");

            // showing a message in the console
            Console.WriteLine(flame_swordsman.Attack());
            Console.WriteLine(black_luster_soldier.Attack());
            Console.WriteLine(gaia_fierce.Attack(30));
            Console.WriteLine(gaia_fierce.Attack(99));
            Console.WriteLine(magro_nego.Attack(100));
            Console.WriteLine(senior_silver.Attack());
        }
    }
}
