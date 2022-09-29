namespace nyaralas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Rossz érték!");
            }

            int m;
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0)
            {
                Console.WriteLine("Rossz érték!");
            }

            double[] x = new double[m];

            for (int i = 0; i < m; i++)
            {
                double d;
                while (!double.TryParse(Console.ReadLine(), out d) || d < 0)
                {
                    Console.WriteLine("Rossz érték!");
                }

                x[i] = d;
            }

            int db = 0;
            
            for (int i = 0; i < m; i++)
            {
                if (x[i] / n > 100.0)
                {
                    db++;
                }
            }

            Console.WriteLine(db);
        }
    }
}