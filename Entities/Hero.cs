namespace RPG.Entities
{
    public abstract class Hero
    {

        public  Hero(string Name, int Level, string HeroType, string Speciality)
        {
            this.Name = Name ; 
            this.Level = Level; 
            this.HeroType = HeroType; 
            this.Speciality = Speciality;
            
        }


        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public string Speciality { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType +"" + this.Speciality   ; 
        }

        public virtual string Attack(int Bonus)
        {
            if( Bonus >= 6)
            {
                 return this.Name + " " + $"has attacked whith his Elf arrow (status: Power {Bonus}) " ;
            }
            else
            {
                 return this.Name + " " + $"has attacked whith his  sword (status: Power {Bonus})" ;
            }
            
        }


         public virtual string Defense(int Bonus)
        {
            if(Bonus >= 6)
            {
                 return this.Name + " " + $"has defended whith his shield  (status: Power {Bonus})"  ;
            }else 

            {
                return this.Name + " " + $"has defended but his shield was broken  (status: Power {Bonus})";
            }

           

        }


    }
}