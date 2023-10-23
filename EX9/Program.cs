namespace EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("test", "test", 1);


            Personne personne2 = new Personne("Jeff", "Erson", 18);



            Etudiant etudiant1 = new Etudiant("Jeff", "Erson", 1, "Buisness");


            Console.WriteLine(etudiant1);

            Etudiant etudiant2 = new Etudiant("Joe", "Blo", 10, "Info");

            Console.WriteLine(etudiant2);
        }
    }
}
