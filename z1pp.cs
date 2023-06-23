using System;

class Program
{
    static void Main()
    {
        int[] tablica = GenerujTablice(10); 
        WypiszOdTylu(tablica); 

        Console.ReadKey();
    }

    static int[] GenerujTablice(int rozmiar)
    {
        Random rand = new Random();
        int[] tablica = new int[rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(1, 100); 
        }

        return tablica;
    }

    static void WypiszOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}