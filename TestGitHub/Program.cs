using System.ComponentModel.Design;

namespace TestGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("Entrer un montant a calculer");
                string test = Console.ReadLine();
                try
                {
                    int result = Int32.Parse(test);
                    double TPS = result * 0.05;
                    Console.WriteLine("TPS: "+TPS);
                    double TVQ = result * 0.09975;
                    Console.WriteLine("TVQ: "+TVQ);
                    double TOTAL = result + (double)TPS + (double)TVQ;
                    Console.WriteLine("Resultat: "+TOTAL);
                    b = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"'{test}' is not a valid number");
                    continue;
                }
            }
        }
    }
}