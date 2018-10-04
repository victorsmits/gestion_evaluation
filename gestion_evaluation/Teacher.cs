using System;
namespace gestion_evaluation
{
    public class Teacher : Personne
    {
        public int Salary = 0;

        public Teacher(string fname, string lname, int Pay) : base(fname, lname)
        {
            this.Salary = Pay;
        }
    }
}
