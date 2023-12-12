using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä suurempi kokonaisluku kuin 10: ");
        int luku = int.Parse(Console.ReadLine());

        if (luku > 10)
        {
            for (int i = 1; i <= 13; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(luku);
                        if (j < i - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Syötä suurempi luku kuin 10.");
        }
    }
}