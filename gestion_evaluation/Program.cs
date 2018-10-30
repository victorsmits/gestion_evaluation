﻿using System;
using System.Threading;

namespace gestion_evaluation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student("victor", "smits");
            s.DisplayName();

            Teacher t = new Teacher("j", "c", 10);

            Activity a = new Activity(t, 1, "test", "tt");

            Cote c = new Cote(a, 0xA);
            Appreciation A = new Appreciation(a, "TB");
            s.Add(A);
            s.Add(c);

            Console.Write(s.Bulletin());
            Console.Write("\nmoyenne" + s.Average());
        }
    }
}
