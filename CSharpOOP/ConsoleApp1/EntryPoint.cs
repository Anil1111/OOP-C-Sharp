using Characters;
using System;

    public class EntryPoint
    {
        static void Main()
        {
            Warrior theGoodGuy = new Warrior(190, 80, "Good guy");

            Warrior theBadGuy = new Warrior(170, 90, "Bad Guy");

            Console.WriteLine(theGoodGuy.Height);
            Console.WriteLine(theBadGuy.Height);

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);


        }
    }
