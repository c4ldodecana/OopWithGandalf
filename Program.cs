using System;
using RPG.Entities; 
using static System.Console; 


namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knigth Aragorn = new Knigth("Aragorn", 57, "Knigth", "agility"); 
            Wizard Gandalf = new Wizard("Gandalf", 120, "Maiar","Ligth magic and restore health" );
            Balrog Kazdur = new Balrog ("Kazdur", 580, " Balrog", "Fire and Shadows" );



            WriteLine("Demon Power value:");
            WriteLine(Kazdur.Attack(int.Parse(ReadLine() ) ) );
            WriteLine("Hero Power value:");
            WriteLine(Aragorn.Defense( int.Parse(ReadLine() ) ));
            WriteLine("Wizard Power value:");
            WriteLine(Gandalf.Attack( int.Parse(ReadLine() ) )); 
            WriteLine();
        }
    }
}