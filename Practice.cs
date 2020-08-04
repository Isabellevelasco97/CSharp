using System;

class practicingCSharp
{
    public static void threeHeads()
    {
        bool threeInARow = false;
        string heads = "H";
        string tails = "T";
        int x = 0;
        int y = 0;
        Random random = new Random();
        
        while (threeInARow == false)
        {
            int HorT = random.Next(0,2);
            if (HorT == 0)
            {
                Console.Write(heads);
                x++;
                y = 0;
            }
            if (HorT == 1)
            {
                Console.Write(tails);
                y++;
                x = 0;
            }
            if (x == 3 || y == 3)
            {
                threeInARow = true;
                Console.WriteLine("\n" + "Three in a row!");
            }
        }
    }
    public static void Main(String[] args)
    {
        threeHeads();
    }
}