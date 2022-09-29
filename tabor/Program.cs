namespace tabor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int elso;

            Console.WriteLine("Napok száma:");

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 7)
            {
                Console.WriteLine("Rossz érték!");
                Console.WriteLine("\nNapok száma:");
            }

            Console.WriteLine("Első nap:");

            while (!int.TryParse(Console.ReadLine(), out elso) || elso <= 0 || elso > 7)
            {
                Console.WriteLine("Rossz érték!");
                Console.WriteLine("\nElső nap:");
            }

            string[] napok = { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" };

            string utolso = napok[(elso + n - 1) % 7];

            Console.WriteLine(utolso);
        }
    }
}