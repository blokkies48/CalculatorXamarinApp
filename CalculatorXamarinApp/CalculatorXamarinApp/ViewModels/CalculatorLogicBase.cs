using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculatorXamarinApp.ViewModels
{
    internal class CalculatorLogicBase: BindableObject
    {

        // Properties
        protected string calcText = "-";

        public string CalcText
        {
            get { return calcText; }
            set
            {
                if (calcText != value)
                {
                    calcText = value;
                    OnPropertyChanged();
                }
            }
        }



        public Command buttonCalculate { set; get; }

        public Command buttonNumerical { set; get; }
        // End
    }
}
