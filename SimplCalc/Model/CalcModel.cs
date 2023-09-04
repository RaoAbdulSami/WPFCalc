using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplCalc.Model
{
    class CalcModel 
    {
  /*      public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string txt;

        public string Txt
        {
            get { return txt; }
            set { txt += value; OnPropertyChanged(nameof(Txt)); }
        }*/

        public double PerformCalculation(double firstNumber, double secondNumber, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                    // Add cases for other operations as needed
            }

            return result;
        }

    }
}
