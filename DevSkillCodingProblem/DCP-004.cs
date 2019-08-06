using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkillCodingProblem
{
    class DCP_004
    {
        static void Main(string[] args)
        {
            //Problem

            string line = Console.ReadLine();
            string[] lineParts = line.Split(' ');

            var projectHour = Convert.ToInt16(lineParts[0]);
            var numberOfDeveloper = Convert.ToInt16(lineParts[1]);

            int[] totalWorkHour = new int[numberOfDeveloper];
            for (int i = 0; i < numberOfDeveloper; i++)
            {
                var perDeveloperWorkHour = Console.ReadLine();
                totalWorkHour[i] = totalWorkHour[i + 1];
            }

            decimal numberOfDayes = projectHour / totalWorkHour[i];
            if (totalWorkHour[i] >= projectHour)
            {
                Console.WriteLine("Project will finish within 1 day");
            }
            else
            {
                numberOfDayes = projectHour / totalWorkHour[i];

                Console.WriteLine("Project will finish within {0} day", numberOfDayes);
            }






        }
    }
}
