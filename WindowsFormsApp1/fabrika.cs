using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class TwoArgumentsFactory
    {

        public static Interface1 Creator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Calc":
                    return new Calc();
                default:
                    throw new Exception("Неизвестная операция");
            }

        }


    }

}