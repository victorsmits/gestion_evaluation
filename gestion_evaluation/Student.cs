using System;
using System.Collections.Generic;
namespace gestion_evaluation
{
    public class Student : Personne
    {
        private List<Evaluation> cours;

        public Student(string fname, string lname) : base(fname, lname)
        {

        }

        public void Add(Evaluation evaluation)
        {

        }

        public double Average()
        {
            return 0;
        }

        public string Bulletin()
        {
            return "";
        }

    }
}
