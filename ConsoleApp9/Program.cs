using System;


namespace Space1
{
    class H1
    {
        int val;
        public void tes(int val)
        {
            this.val = val;
            Console.WriteLine("Hello val: {0} ", val);
        }

        public int s()
        {
            return val;
        }
    }
}




namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Space1.H1 h = new Space1.H1();
            Console.WriteLine("************************************************");

            h.tes(5);

            Console.WriteLine("************************************************");


            Console.WriteLine("value of s: {0} ", h.s());

            Console.WriteLine("************************************************");


        }
    }
}
