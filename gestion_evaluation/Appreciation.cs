using System;
using System.Runtime.CompilerServices;
namespace gestion_evaluation
{
    public class Appreciation : Evaluation
    {
        private string appreciation;

        public Appreciation(Activity a, string app) : base(a)
        {
            this.appreciation = app;
        }

        public int Note()
        {
            return 0;
        }

        public void SetAppreciation(string appreciation)
        {

        }
    }
}
