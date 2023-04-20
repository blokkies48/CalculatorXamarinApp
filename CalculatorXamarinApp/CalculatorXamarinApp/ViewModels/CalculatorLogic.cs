using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace CalculatorXamarinApp.ViewModels
{
    internal class CalculatorLogic : CalculatorLogicBase
    {
        // Class variables
        bool hasCalculated = false;
        // End
        // Constructor
        public CalculatorLogic()
        {
            buttonCalculate = new Command(ButtonCalculate);
            buttonClear = new Command(ButtonClear);
            buttonNumerical = new Command<string>((param) => ButtonNumPressed(param));
            buttonOperation = new Command<string>((param) => ButtonOperationPressed(param));
        }
        // End


        // Methods

        void Calculations()
        {          
            SecondText = $"{ValueBuffer} {OperationInWork} {ValueInWork} =";
            switch (OperationInWork)
            {

                case "+":
                    CalcText =
                        (Result = ValueBuffer + ValueInWork).ToString();
                    ValueInWork = decimal.Parse(CalcText);
                    break;
                case "-":
                    CalcText =
                        (Result = ValueBuffer - ValueInWork).ToString();
                    ValueInWork = decimal.Parse(CalcText);
                    break;
                case "*":
                    CalcText =
                        (Result = ValueBuffer * ValueInWork).ToString();
                    ValueInWork = decimal.Parse(CalcText);
                    break;
                case "/":
                    try
                    {
                        CalcText =
                            (Result = ValueBuffer / ValueInWork).ToString();
                        ValueInWork = decimal.Parse(CalcText);
                    }
                    catch (DivideByZeroException error)
                    {
                        CalcText = error.ToString();
                    }

                    break;
            }
            ValueBuffer = 0;
            Result = 0;
            OperationInWork = "";
            
        }
        void ButtonCalculate()
        {            
            hasCalculated = true;
            Calculations();            
        }

        void ButtonNumPressed(string number)
        {
            if (hasCalculated)
            {
                CalcText = "-";
                hasCalculated = false;
            }

            if (CalcText == "-")
            {
                CalcText = number;                
            }
            else
            {
                CalcText += number;                
            }
            ValueInWork = decimal.Parse(CalcText);

        }

        void ButtonOperationPressed(string operation)
        {
            if (hasCalculated)
            {                
                CalcText = "0";
                ValueInWork = 0;
                hasCalculated = false;
            }
            else
            {
                Calculations();
            }

            SecondText = $"{ValueInWork} {operation}";
            OperationInWork = operation;
            ValueBuffer = decimal.Parse(CalcText);

            CalcText = "-";
        }
        void ButtonClear()
        {
            ValueBuffer = 0;
            Result = 0;
            ValueInWork = 0;
            SecondText = "-";
            CalcText = "-";
            OperationInWork = "";
        }

        // End
    }
}
