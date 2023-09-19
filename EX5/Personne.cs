using System.Collections.Generic;

namespace EX5
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        public Personne(string nom, string prenom, int age = 0)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {this.nom} Prenom: {this.prenom} age: {this.age}");
        }
    }
}
