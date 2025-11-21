namespace ProkopJL_projektgyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                Console.WriteLine("2. új e-mail");
                Console.WriteLine("3. érvényes e-mailok");
                Console.WriteLine("4. érvényes e-mailok");

                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return;
                    case "1": Console.WriteLine("e-mailek listázása"); break;
                    case "2": Console.WriteLine("új e-mailek"); break;
                    case "3": Console.WriteLine("e-mail törlése"); break;
                    case "4": Console.WriteLine("érvényesek listázás"); break;
                    default: Console.WriteLine("rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
