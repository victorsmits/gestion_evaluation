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
            return 0;
        }

        public void Bulletin()
        {
            foreach (Evaluation e in cours)
            {
                Console.Write("\n{0} : {1}", e.activité.Name
                              , e.Note());
            }
        }

    }
}
