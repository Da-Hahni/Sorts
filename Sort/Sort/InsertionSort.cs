namespace Sort;

public class InsertionSort : ISort
{
    public void Sort(int[] uzahlen)
    {
        for (int i = 1; i < uzahlen.Length; i++)
        {
            int temp = uzahlen[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < uzahlen.Length; i++)
        {
            Console.Write(uzahlen[i] + " ");
        }
    }
}