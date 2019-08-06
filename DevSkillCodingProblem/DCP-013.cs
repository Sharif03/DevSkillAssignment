using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkillCodingProblem
{
    class DCP_013
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                string line1 = Console.ReadLine();
                string[] lineParts1 = line1.Split(' ');

                int b1Score = Convert.ToInt16((lineParts1[0]));
                int b2Score = Convert.ToInt16((lineParts1[1]));

                int p1Score = Convert.ToInt16((lineParts1[2]));
                int p2Score = Convert.ToInt16((lineParts1[3]));


                string line2 = Console.ReadLine();
                string[] lineParts2 = line2.Split(' ');

                int b3Score = Convert.ToInt16((lineParts2[0]));
                int b4Score = Convert.ToInt16((lineParts2[1]));

                int p3Score = Convert.ToInt16((lineParts2[2]));
                int p4Score = Convert.ToInt16((lineParts2[3]));

                int match1Bangla = b1Score + b2Score; 
                int match1Paki = p1Score + p2Score; 

                int match2Bangla = b3Score + b4Score; 
                int match2Paki = p3Score + p4Score;

                string playCard = ((match1Bangla> match1Paki) &&(match2Bangla> match2Paki)) ? "Miss" : "Banglawash";
                Console.WriteLine(playCard);

                //int totalb = b1Score + b2Score + b3Score + b4Score;
                //int totalp = p1Score + p2Score + p3Score + p4Score;

                //string playCard = (totalb <= totalp) ? "Miss" : "Banglawash";
                //Console.WriteLine(playCard);
            }
        }
    }
}
