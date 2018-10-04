using System;
using System.Globalization;
namespace gestion_evaluation
{
    public class Activity
    {
        public int ECTS;
        public string Name;
        public string Code;
        public Teacher t;

        public Activity(Teacher teacher, int Credit, string Nom, string imat)
        {
            this.Code = imat;
            this.ECTS = Credit;
            this.Name = Nom;
            this.t = teacher;
        }
    }
}
