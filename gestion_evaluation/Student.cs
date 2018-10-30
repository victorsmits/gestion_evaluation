using System;
using System.Collections.Generic;
namespace gestion_evaluation
{
    public class Student : Personne
    {
        private List<Evaluation> cours = new List<Evaluation>();

        public Student(string fname, string lname) : base(fname, lname)
        {

        }

        public void Add(Evaluation evaluation)
        {
            cours.Add(evaluation);
        }

        public double Average()
        {
            double i = 0;
            double tot = 0;
            double average = 0;

            foreach (Evaluation e in cours)
            {
                tot += e.Note();
                i++;
            }
            average += tot / i;
            return average;
        }

        public string Bulletin()
        {
            string bulletin = "";
            foreach (Evaluation e in cours)
            {
                bulletin += "\n";
                bulletin += e.activité.Name + " " + e.activité.Code;
                bulletin += " : ";
                bulletin += e.Note();

            }
            return bulletin;
        }

    }
}
