using System;

namespace FinalHandsOn1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Josh";
            char middleInitial = 'E';
            string lastName = "Hilton";
            int age = 20;
            int weight = 545;
            int heightInInches = 74;
            string bevOfChoice = "water";
            string shirtColor = "red";
            string pantColor = "gray";
            bool shoes = false; //true is shoes on
            bool pets = true; //true is has pets
            int moneyInAccount = 5000000;
            bool hungry = false;
            int shoeSize = 11;
            bool tired = true;
            /*The c# naming convention is to make the variable as specific as possible.
             * people reading the code should know exactly what you are talking about just by 
             * reading the variable names*/
            Console.WriteLine(firstName+" "+middleInitial+" "+lastName+" "+"is "+age+" years old and weighs "+weight+"lbs. He is "+heightInInches+"" +
                " inches tall and wears shoe size " +shoeSize+". His beverage of choice is "+bevOfChoice+". His shirt is "+shirtColor+" and his pants are "+pantColor+
                ". He has "+moneyInAccount+" dollers in his account. He has shoes on?: "+shoes+". He has pets?: "+pets+". He is hungry?: "+hungry+". He is tired?: "+tired+".");
        }
    }
}
