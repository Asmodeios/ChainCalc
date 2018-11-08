using ChainCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainCalculator.Handlers
{
    abstract class Handler
    {
        protected Handler next;

        public void SetNext(Handler next)
        {
            this.next = next;
        }

        public abstract void HandleRequest(Request req);
    }
}
