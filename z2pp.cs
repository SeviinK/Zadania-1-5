using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 10, 3, 8, 2, 7 }; 

        int najmniejszy = ZnajdzNajmniejszy(tablica); 
        int największy = ZnajdzNajwiekszy(tablica); 

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + największy);

        Console.ReadKey();
    }

    static int ZnajdzNajmniejszy(int[] tablica)
    {
        int najmniejszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }
        }

        return najmniejszy;
    }

    static int ZnajdzNajwiekszy(int[] tablica)
    {
        int największy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > największy)
            {
                największy = tablica[i];
            }
        }

        return największy;
    }
}
