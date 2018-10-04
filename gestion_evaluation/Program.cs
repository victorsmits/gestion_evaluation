using System;
using System.Threading;

namespace gestion_evaluation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student("victor", "smits");
            s.DisplayName();
        }
    }
}
