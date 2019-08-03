using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkillCodingProblem
{
    class DCP_001
    {
        static void Main(string[] args)
        {
            var T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');

                var v = Convert.ToDecimal(lineParts[0]);
                var t = Convert.ToDecimal(lineParts[1]);
                double r = (double)(v / t);
                Console.WriteLine(string.Format("-{0:n2}", r));
            }
        }
    }
}
