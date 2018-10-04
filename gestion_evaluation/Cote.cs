using System;
namespace gestion_evaluation
{
    public class Cote : Evaluation
    {
        private int note;

        public Cote(Activity a, int score)
        {
            this.note = score;
            base.activité = a;
        }

        public override int Note()
        {
            return note;
        }

        public void SetNote(int score)
        {
            this.note = score;
        }
    }
}
