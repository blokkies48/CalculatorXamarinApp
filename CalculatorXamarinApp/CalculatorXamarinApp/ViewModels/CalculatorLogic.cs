using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculatorXamarinApp.ViewModels
{
    internal class CalculatorLogic : CalculatorLogicBase
    {
        // Class variables

        // End
        // Constructor
        public CalculatorLogic()
        {
            buttonCalculate = new Command(ButtonCalculate);
            buttonNumerical = new Command<string>((param) => ButtonNumPressed(param));
        }
        // End


        // Methods
        void ButtonCalculate()
        {
            CalcText = "-";
        }

        void ButtonNumPressed(string number)
        {
            if (CalcText == "-")
            {
                CalcText = number;
            }
            else
            {
                CalcText += number;
            }
        }
        // End
    }
}
