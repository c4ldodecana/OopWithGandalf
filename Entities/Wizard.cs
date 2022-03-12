using System; 
namespace RPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, string Speciality) : base(Name, Level, HeroType, Speciality)
        {
             this.Name = Name ; 
            this.Level = Level; 
            this.HeroType = HeroType; 
        }
      

        public string Attack(int Bonus)
        {
          if(Bonus  >= 6)
          {
             return this.Name +" " + $"has attacked with a ligth magic (status: Power {Bonus}) " ;   
          }
          else 
          {
                return this.Name +" " + $"has attacked with his staff (Power: {Bonus})  " ; 
          }
        }


               public virtual string Defense(int Bonus)
        {
            if(Bonus >= 6)
            {
                 return this.Name + " " + $"has defended whith his ligth shield (Power: {Bonus}) " ;
            }else 

            {
                return this.Name + " " + $"has defended with his staff (Power: {Bonus}) " ;
            }

           

        }
    }
}