namespace EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("test", "test", 1);


            Personne personne2 = new Personne("Jeff", "Erson", 18);



            Etudiant etudiant1 = new Etudiant("Jeff", "Erson", 1, "Math");


            Console.WriteLine(etudiant1);
        }
    }
}
