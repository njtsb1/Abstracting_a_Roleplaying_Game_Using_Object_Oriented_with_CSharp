namespace Abstraction_RPG_Game_in_C.src.Entities
{
    // public class Ninja that inherits the Hero class
    public class Ninja : Hero
    {
        // builder with the features
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        // overrides the default behavior with a message
        public override string Attack(){
             return this.Name + " Attacked with your Dagger.";
        }
    }
}