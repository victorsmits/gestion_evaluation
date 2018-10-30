using System;
using System.Runtime.CompilerServices;
namespace gestion_evaluation
{
    public class Appreciation : Evaluation
    {
        private string appreciation;

        public Appreciation(Activity a, string app)
        {
            this.appreciation = app;
            base.activité = a;
        }

        public override int Note()
        {
            switch (this.appreciation)
            {
                case "TB": return 20;
                case "B": return 16;
                case "C": return 12;
                case "N": return 8;
                case "X": return 4;
            }
            return 0;
        }

        public void SetAppreciation(string app)
        {
            this.appreciation = app;
        }
    }
}
