using ChainCalculator.Handlers;
using ChainCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler sum = new SumHandler();
            Handler sub = new SubHandler();
            Handler div = new DivHandler();
            Handler mult = new MultHandler();

            sum.SetNext(sub);
            sub.SetNext(div);
            div.SetNext(mult);

            Request r1 = new Request(2, 2, "+");
            sum.HandleRequest(r1);
            r1 = new Request(10, 5, "-");
            sum.HandleRequest(r1);
            r1 = new Request(5, 2, "/");
            sum.HandleRequest(r1);
            r1 = new Request(2, 2, "*");
            sum.HandleRequest(r1);


            Console.ReadKey();
        }
    }
}
