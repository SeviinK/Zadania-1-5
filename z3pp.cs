using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 8, 1, 9 }; 

        SortowanieBąbelkowe(tablica); 

        Console.WriteLine("Posortowana tablica:");
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.ReadKey();
    }

    static void SortowanieBąbelkowe(int[] tablica)
    {
        int n = tablica.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    ZamieńElementy(tablica, j, j + 1);
                }
            }
        }
    }

    static void ZamieńElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    }
}
