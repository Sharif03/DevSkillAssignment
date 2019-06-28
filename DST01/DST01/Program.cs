using System;

namespace DST01
{
    class Program
    {
        static void Main(string[] args)
        {
            //double d = 5.021;
            //int a = 10;
            //a = Convert.ToInt16(d);
            ////Console.WriteLine("Hello World! " + d.ToString().GetType());
            ////Console.WriteLine("Hello World! {0}", d.GetType());

            //object x = 10.06;
            //dynamic y = 20.5;
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(y.GetType());

            //var z = 'z';
            //Console.WriteLine(z.GetType());

            Guid g = Guid.NewGuid();
            DateTime d = new DateTime();
            //Console.WriteLine(d);

            //int? age = null;
            //Console.WriteLine(age);

            int ag = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(ag);


            Console.ReadLine();
        }
    }
}
