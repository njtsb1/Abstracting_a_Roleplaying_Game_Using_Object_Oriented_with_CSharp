namespace Abstraction_RPG_Game_in_C.src.Entities
{
    // public class Warrior that inherits class Hero
    public class Warrior : Hero
    {
        // builder with the features
        public Warrior(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            
        }
    }

}