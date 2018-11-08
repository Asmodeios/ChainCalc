using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainCalculator.Model
{
    class Request
    {
        private int firstNumber;
        private int secondNumber;
        private string oper;


    public Request(int firstNumber, int secondNumber, string oper)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.oper = oper;
        }

        public int FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }

        public int SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }

        public string Oper
        {
            get { return oper; }
            set { oper = value; }
        }
    }
}
