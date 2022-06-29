using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Calc : Interface1
    {
        public float Calculate(float a, float b, string c)
        {
            switch (c)
            {
                case "+":
                    return a + b;

                case "-":
                    return a - b;

                case "*":
                    return a * b;

                case "/":
                    return a / b;

                case "^":
                    return (float)Math.Pow(a, b);

                case "e^":
                    return (float)Math.Exp(a);
            }
            return 0;
        }
    }
}
