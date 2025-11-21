namespace ProkopJL_projektgyak
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            List<string> e_mailok = new List<string>();
            e_mailok.Add("alma1@kört.hu");
            e_mailok.Add("alma2@dfdfdf.hu");
            e_mailok.Add("alma3@ssdsds.hu");
            e_mailok.Add("deak.csaba@kkszki.hu");
            e_mailok.Add("alma.korte@alma.hu");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                int sorszam = 0;
                foreach (string e_mail in e_mailok){
                    Console.WriteLine($"{sorszam++} {e_mail}");
                }
                break;
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
