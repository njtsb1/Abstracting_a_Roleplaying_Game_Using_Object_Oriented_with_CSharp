namespace Abstraction_RPG_Game_in_C.src.Entities
{
    // public class Knight that inherits the Hero class
    public class Knight : Hero
    {
        // builder with the features
        public Knight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        // overrides the default behavior with a message
        public override string Attack(){
        return this.Name + " Attacked with his spear";
        }

        // bonus attack method
        public string Attack(int Bonus){

            // if the bonus is greater than 98 show a message, otherwise show another message
            if (Bonus > 98){
            return this.Name + " Super Effective Spear Attack with Bonus " + Bonus;
            }else{
                return this.Name + "Spear attack with weak force with bonus " + Bonus;
            }
    }
}
}