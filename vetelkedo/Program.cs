namespace vetelkedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Rossz érték!");
            }

            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                int ev;

                while (!int.TryParse(Console.ReadLine(), out ev) || ev < 0)
                {
                    Console.WriteLine("Rossz érték!");
                }

                x[i] = ev;
            }

            bool volte = false;
            int j = 0;
            
            while (j < n && !volte)
            {
                volte = x[j] > 2004;
                j++;
            }

            Console.WriteLine(volte);
        }
    }
}