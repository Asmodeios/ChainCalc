using ChainCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainCalculator.Handlers
{
    class DivHandler : Handler
    {
        public override void HandleRequest(Request req)
        {
            if (req.Oper == "/")
            {
                double res = (double)req.FirstNumber / (double)req.SecondNumber;
                System.Console.WriteLine(req.FirstNumber + " "  + req.Oper + " "  + req.SecondNumber + " = " + res);
            }
            else if (next != null)
            {
                next.HandleRequest(req);
            }
        }
    }
}
