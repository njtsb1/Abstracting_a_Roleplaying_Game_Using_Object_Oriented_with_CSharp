namespace Abstraction_RPG_Game_in_C.src.Entities
{

    // abstract class Hero
    public abstract class Hero
    {
        // builder with the features
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        // empty constructor
        public Hero(){

        }

        // to be able to use the objects
        public string Name;
        public int Level;
        public string HeroType;

        // overrides the default behavior with a message
        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        
        // attack method 
        public virtual string Attack(){
            return this.Name + " Attacked with his sword.";
        }


    }
}