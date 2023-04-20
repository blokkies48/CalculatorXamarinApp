using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculatorXamarinApp.ViewModels
{
    internal class CalculatorLogicBase : BindableObject
    {

        // Properties
        protected string calcText = "-";

        public string CalcText
        {
            get { return calcText; }
            set
            {
                if (value.Length > 15)
                {
                    value = value.Substring(0, 12);                    
                }
                if (calcText != value)
                {
                    calcText = value;
                    OnPropertyChanged();
                }
            }
        }
        protected string secondText = "-";

        public string SecondText
        {
            get { return secondText; }
            set
            {
                if (secondText != value)
                {
                    secondText = value;
                    OnPropertyChanged();
                }
            }
        }

        protected decimal result;

        public decimal Result
        {
            get => result;
            set
            {
                if (result != value)
                {
                    result = value;
                }
            }
        }

        protected decimal valueInWork;

        public decimal ValueInWork
        {
            get => valueInWork;
            set
            {
                if (valueInWork != value)
                {
                    valueInWork = value;
                }
            }
        }

        protected decimal valueBuffer;

        public decimal ValueBuffer
        {
            get => valueBuffer;
            set
            {
                if (valueBuffer != value)
                {
                    valueBuffer = value;
                }
            }
        }

        protected string operationInWork;

        public string OperationInWork
        {
            get => operationInWork;
            set
            {
                if (operationInWork != value)
                {
                    operationInWork = value;
                }
            }
        }


        public Command buttonCalculate { set; get; }

        public Command buttonNumerical { set; get; }

        public Command buttonOperation { set; get; }
        public Command buttonClear { set; get; }
        // End
    }
}