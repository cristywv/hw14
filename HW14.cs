using System;

namespace hw14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            string b = "Cristy";
            float c = 1.1F;
            double d = 2.2d;
            bool e = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        
            Console.WriteLine("My name is {0} and my favorite number is {1}. This is a {2} statement.", b, a, e);
         
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
       
            Console.WriteLine(a < c);
            Console.WriteLine(c > d);
            Console.WriteLine("Love" != "Hate");
            Console.WriteLine("Love" == "Love");

            Console.ReadKey();
        }

        public void thisPub()
        {
            Console.WriteLine("This is public.");
        }

        private void thisPri()
        {
            Console.WriteLine("This is private.");
        }

        public string z()
        {
            string y = "yakkity yakk yak";
            return y;
        }

        public void pet( string cats, string dogs)
        {
            Console.WriteLine("i have {0} and {1}.", cats, dogs);
        }

        
    }
}
