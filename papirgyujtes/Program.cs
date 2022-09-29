namespace papirgyujtes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Rossz érték!");
            }

            double[] x = new double[n];
            string tomb = Console.ReadLine();
            
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToDouble(tomb.Split()[i]);
            }

            double s = 0;

            for (int i = 0; i < n; i++)
            {
                s += x[i];
            }

            Console.WriteLine(s);
        }
    }
}