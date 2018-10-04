using System;
using System.ComponentModel;
namespace gestion_evaluation
{
    public class Personne
    {
        public string name;
        public string firstname;

        public Personne(string fname, string lname)
        {
            this.name = lname;
            this.firstname = fname;
        }

        public void DisplayName()
        {
            Console.Write("{0} {1}", name, firstname);
        }
    }
}
