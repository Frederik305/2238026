using System.Xml.Schema;

namespace EX2
{
    internal class Program
    {
        public static float ObtenirMontant()
        {
            while (true)
            {
                Console.WriteLine("Entrez le montant: ");

                if (float.TryParse(Console.ReadLine(), out float montant))
                {
                    return montant;
                }
                else { Console.WriteLine("vous devez indiquer un montant valide! "); }
            }
        }

        public static void montantTVQ(string[] args) { }

        public static float calculerTaxes(float montant, out float montantTPS, out float montantTVQ)
        {
            montantTPS = montant * 0.05f;
            montantTVQ = montant * 0.09975f;
            return montant+montantTPS+montantTVQ;
        }

        static void Main(string[] args)
        {
            float montant = ObtenirMontant();
            float total = calculerTaxes(montant, out float montantTPS, out float montantTVQ);
            Console.WriteLine("montant: "+montant+"\nmontantTPS: "+montantTPS+"\nmontantTVQ: "+montantTVQ+"\nTotal: "+total);
        }
    }
}