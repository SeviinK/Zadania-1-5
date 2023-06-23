using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 8, 1, 9 }; 

        SortowaniePrzezWybieranie(tablica); 

        Console.WriteLine("Posortowana tablica:");
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.ReadKey();
    }

    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i;
            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            if (indeksMinimum != i)
            {
                ZamieńElementy(tablica, i, indeksMinimum);
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
