using ChainCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainCalculator.Handlers
{
    class SubHandler : Handler
    {
        public override void HandleRequest(Request req)
        {
            if (req.Oper == "-")
            {
                int res = req.FirstNumber - req.SecondNumber;
                System.Console.WriteLine(req.FirstNumber + " " + req.Oper + " " + req.SecondNumber + " = " + res);
            }
            else if (next != null)
            {
                next.HandleRequest(req);
            }
        }
    }
}
