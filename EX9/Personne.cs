using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9
{
    public class Personne
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

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom: {this.nom} Prenom: {this.prenom} age: {this.age}");
        }
    }
    internal class Etudiant : Personne
    {
        private string domaineEtude;
        public Etudiant(string nom, string prenom, int age, string domaineEtude) : base(nom, prenom, age)
        {
            this.domaineEtude = domaineEtude;
        }
        public string DomaineEtude
        {
            get { return this.domaineEtude; }
            set { this.domaineEtude = value; }
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Domaine: {domaineEtude}");
        }
    }
}