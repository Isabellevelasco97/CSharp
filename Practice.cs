using System;

class practicingCSharp
{
    public static void threeHeads()
    {
        bool threeInARow = false;
        string heads = "H";
        string tails = "T";
        int x, y = 0;
        Random random = new Random();
        int HorT = random.Next(0,2);
        
        while (threeInARow == false)
        {
            if (HorT == 0)
            {
                Console.Write(heads);
                x++;
                y = 0;
            }
            else
            {
                Console.Write(tails);
                y++;
                x = 0;
            }
        }
        if (x == 3 || y == 3)
        {
            threeInARow = true;
            Console.WriteLine("Three in a row!");
        }
    }
    public static void Main(String[] args)
    {

    }
}