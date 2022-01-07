using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sami sami = new Sami();
            tuhin t=new tuhin();
            //t.sadman();
            siyam siyam = new siyam();
            siyam.sadman();
            Console.ReadKey();

        }
       
    }
    class Sami
    {
        public int wheels = 4;
        public void lol()
        {
            Console.WriteLine("This is class sami");
        }
        public void sadman()
        {
            Console.WriteLine("this is class sadman");
        }

    }
    class tuhin : Sami
    {
        public int lol=2;
       public void rezab()
        {
            Console.WriteLine("Rezab is tuhin");
        }
    }
    class siyam : Sami
    {
        public int rofl = 4;
    }
    
}
