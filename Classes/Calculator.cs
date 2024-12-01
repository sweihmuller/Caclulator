using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclulator
{
    internal class Calculator
    {
        private float numberOne;
        private float numberTwo;

        public float NumberOne
        {
            set { this.numberOne = value; }
            get { return numberOne; }
        }

        public float NumberTwo
        {
            set { this.numberTwo = value; }
            get { return numberTwo; }
        }

        public float Add(float numberOne, float numberTwo)
        {
            return numberOne + numberTwo;
        }

        public float Substract(float numberOne, float numberTwo)
        {
            return numberOne - numberTwo;
        }

        public float Multiply(float numberOne, float numberTwo)
        {
            return numberOne * numberTwo;
        }

        public float Divide(float numberOne, float numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
