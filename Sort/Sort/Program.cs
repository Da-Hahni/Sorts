namespace Sort;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Gib die Arraygröße an, die dann mit random Zahlen generiert wird");
        int[] uzahlen = new int[Convert.ToInt64(Console.ReadLine())];


        Console.WriteLine("Was wollen sie tun? \n m(Sort methode) \n u(unsortiertes Array) \n p(Programm beenden)");        
        Random rnd = new Random();
        for (int i = 0; i < uzahlen.Length; i++)
        {
            uzahlen[i] = rnd.Next(1, 200);
        }
        char auswahl = Convert.ToChar(Console.ReadLine() ?? "m");
        switch (auswahl)
        {
            case 'm':
                Console.WriteLine("Gib die Methode an die du verwenden willst. 1(BubbleSort), 2(Insertion sort), 3(Selection Sort)");
                int methode = Convert.ToInt32(Console.ReadLine());
                ISort sort;
                
                switch (methode)
                {
                    case 1:
                        sort = new BubbleSort();
                        sort.Sort(uzahlen);
                        break;
            
                    case 2:
                        sort = new InsertionSort();
                        sort.Sort(uzahlen);                                 //ich liebe dihc morizz
                        break;
            
                    case 3:
                        sort = new SelectionSort();
                        sort.Sort(uzahlen);
                        break;
                }
                break;
            case 'u':
                for (int i = 0; i < uzahlen.Length; i++)
                {
                    Console.Write(uzahlen[i] + " ");
                }
                break;
        }
    }
}



