namespace Sort;

public class BubbleSort : ISort
{
    public void Sort(int[] uzahlen)
    {
        for (int j = 1; j < uzahlen.Length; j++)
        {
            for (int i = 0; i < uzahlen.Length - j; i++) //j verhindert das kontrollieren von sortierten Zahlen (rechts)
            {
                if (uzahlen[i] > uzahlen[i + 1])
                    (uzahlen[i], uzahlen[i + 1]) = (uzahlen[i + 1], uzahlen[i]);
            }
        }

        for (int i = 0; i < uzahlen.Length; i++)
        {
            Console.Write(uzahlen[i] + " ");
        }
    }
}