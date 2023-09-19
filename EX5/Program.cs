using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("test","test",1);

            personne1.Afficher();
            personne1.Age = 1;
        }
    }
}
