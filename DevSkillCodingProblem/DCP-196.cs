using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkillCodingProblem
{
    class DCP_001
    {
        static void Main(string[] args)
        {
            var T = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var v = Convert.ToDecimal(Console.ReadLine());
                var t = Convert.ToDecimal(Console.ReadLine());
                int r = (int)(v / t);
                Console.WriteLine(string.Format("-{0:n2}", r));
            }
        }
    }
}
