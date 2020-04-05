using System;

namespace ConsoleApp1
{
    class Datum
    {
        private string S;
        public string s { get { return S; } set { S = value; A(); } }

        public Datum()
        {
        }

        public void A()
        {
            S += "d";
        }
    }

    class Program
    {
        static public Datum D;
        static void Main(string[] args)
        {
            Datum d = new Datum() { s = "vv" };
            D = d;
            d.A();
            Console.WriteLine(D.s);

        }
    }
}
