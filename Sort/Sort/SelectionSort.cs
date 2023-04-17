namespace Sort
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] uzahlen)
        {
            for (int i = 0; i < uzahlen.Count; i++)
            {
                int indexMin = i;
                for (int j = i; j < uzahlen.Count; j++)
                {
                    if (uzahlen[j] < uzahlen[indexMin])
                    {
                        indexMin = j;
                    }
                }

                if (i != indexMin)
                {
                    (uzahlen[i], uzahlen[indexMin]) = (uzahlen[indexMin], uzahlen[i]);
                }

            }
            for (int i = 0; i < uzahlen.Length; i++)
            {
                Console.Write(uzahlen[i] + " ");
            }
        }
    }
}
