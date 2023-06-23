using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 8, 1, 9 }; 

        SortowaniePrzezWstawianie(tablica); 

        Console.WriteLine("Posortowana tablica:");
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.ReadKey();
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;
        for (int i = 1; i < n; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }
    }
}
