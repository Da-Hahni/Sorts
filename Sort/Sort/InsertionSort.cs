namespace Sort;

public class InsertionSort : ISort
{
    public void Sort(int[] uzahlen)
    {
        int[] szahlen = new int[uzahlen.Length];
        int j = 0;
        for (int i = 0; i < uzahlen.Length; i++)
        {
            if (uzahlen[i] > szahlen[j])
            {
                szahlen[i] = uzahlen[j];
            }
            else
            {
                szahlen[i - 1] = uzahlen[j];
            }
            j++;
        }
        for (int i = 0; i < szahlen.Length; i++)
        {
            Console.Write(szahlen[i] + " ");
        }
    }
}