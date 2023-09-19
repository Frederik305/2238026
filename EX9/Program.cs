namespace EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("test", "test", 1);

            personne1.Afficher();
            personne1.Age = 1;

            Personne personne2 = new Personne("Jeff", "Erson", 18);

            personne2.Afficher();
        }
    }
}
