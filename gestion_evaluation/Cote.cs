using System;
namespace gestion_evaluation
{
    public class Cote : Evaluation
    {
        private int note;

        public Cote(Activity a, int score) : base(a)
        {
            this.note = score;
        }

        public int Note()
        {
            return 0;
        }

        public void SetNote(int score)
        {

        }
    }
}
