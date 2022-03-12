namespace RPG.Entities
{
    public abstract class Demon
    {
        public Demon(string Name, int Level, string DemonType, string Speciality)
        {
            this.Name = Name ;
            this.Level = Level; 
            this.DemonType = DemonType; 
            this.Speciality = Speciality; 

        }


        public string Name { get; set; }
        public int Level { get; set; }
        public string DemonType { get; set; }
        public string Speciality {get; set; }


        public override string ToString()
        {
            return this.Name + "" + this.Level + "" + this.DemonType + "" + this.Speciality;
        }

        public virtual string Attack(int Bonus)
        {

            if(Bonus >= 6)
            {
                 return this.Name + "  " + $"has attacked with fire balls (Power: {Bonus})"; 
            }
            else {
                return this.Name + " "+ $"has attacked with shadow balls (Power: {Bonus})" ;
            }

        }

        public virtual string Defense(int Bonus)
        {
            if(Bonus>= 6 )
            {
                return this.Name + $" has defended with his shadow shield (Power: {Bonus}) "; 

            }else{
            
                    return this.Name + "" + $"has defended with his shadow whips (Power: {Bonus})  " ;
            }
        }


    }
}