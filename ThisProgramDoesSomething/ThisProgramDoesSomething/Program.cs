using System;

namespace ThisProgramDoesSomething
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Insert 1st Value:");
            int BluPaint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("We wish you a merry christmas,");
            int Flippers = 0;
            while(Flippers <= 2)
            {
                Console.WriteLine(BluPaint); 
                Flippers ++;
            }
            Console.WriteLine("Your 1st Value is:" + BluPaint);
            
            Console.WriteLine("Insert 2nd Value:");
            int BluePaint = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("and a happy new year!");
            int Sandals = 0;
            while (Sandals <= 2)
            {
                Console.WriteLine(BluePaint);
                Sandals++;
            }
            Console.WriteLine("Your 2nd Value is:" + BluePaint);

            if (BluPaint == BluePaint)
            {
                Console.WriteLine("Your sum is:" + (BluPaint+BluePaint) * 3);
            }
            else
            {
                Console.WriteLine("Your sum is:" + (BluPaint + BluePaint));
            }

            Console.WriteLine("Insert Name Please:");
            string MapleSyrup = Console.ReadLine();
            Console.WriteLine("Your Name Is Red Paint!");
            Console.WriteLine("Have A Nice Day!");
        }
    }
}
