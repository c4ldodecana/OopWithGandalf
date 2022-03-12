namespace RPG.Entities
{
    public class Knigth :  Hero 
    {
        public Knigth(string Name, int Level, string HeroType, string Speciality) : base(Name, Level, HeroType, Speciality)
        {
             this.Name = Name ; 
            this.Level = Level; 
            this.HeroType = HeroType; 
            this.Speciality = Speciality; 
        }
    }
}