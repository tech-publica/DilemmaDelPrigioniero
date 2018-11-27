using DilemmaDelPrigioniero.Competition;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DilemmaDelPrigioniero
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t = new Tournament();
            //t.Giostra();
            //t.Sort();
            //t.ShowResults();
            var e = new Evolution();
            e.Evolve();
        }
    }
}
