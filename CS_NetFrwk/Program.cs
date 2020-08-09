using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World with .NET Framework");
            C3 obj = new C3(new C2(new C1()));
            Console.ReadLine();
        }
    }


    public class C1
    {
        public void display()
        {
            Console.WriteLine("Display c1");
        }
    }

    public class C2
    {
        C1 o1;
        public C2(C1 o)
        {
            this.o1 = o;
        }
        public void display()
        {
            o1.display();
            Console.WriteLine("Display c2");
        }
    }

    public class C3
    {
        C2 o2;
        public C3(C2 o)
        {
            this.o2 = o;
        }
        public void display()
        {
            o2.display();
            Console.WriteLine("Display c3");
        }
    }
}
