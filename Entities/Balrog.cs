namespace RPG.Entities
{
    public class Balrog : Demon 
    {
         public Balrog(string Name, int Level, string DemonType, string Speciality) : base(Name, Level, DemonType, Speciality)
        {
            this.Name = Name ;
            this.Level = Level; 
            this.DemonType = DemonType; 
            this.Speciality = Speciality; 

        }
    }
}