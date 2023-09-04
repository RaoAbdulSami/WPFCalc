using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SimplCalc.RelayCommands;
using SimplCalc.Model;
using System.ComponentModel;

namespace SimplCalc.ViewModels
{
    class MainWindowViewModel: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string Operation;
        private string inputtxt;
        public double firstNum;
        public double secondNum;

        public string InputTxt
        {
            get { return inputtxt; }
            set { inputtxt = value; OnPropertyChanged(nameof(InputTxt)); }
        }



        public ICommand equal { get; }
        public ICommand getNum { get; }
        public ICommand Operator { get; }
        public CalcModel calcmodel;
        public MainWindowViewModel()
        {
            calcmodel = new CalcModel();
            equal = new RelayCommand(performCalc);
            getNum = new RelayCommand(AddToInputText);
            Operator = new RelayCommand(SetOperation); 
        }


        public void AddToInputText(string text)
        {
           // InputTxt = string.Empty;
            InputTxt +=  text;

        }

        private void SetOperation(string _operator)
        {
            firstNum = double.Parse(InputTxt);
            InputTxt = string.Empty;

            Operation = _operator;
        }
        public void performCalc( string nothing)
        {
            secondNum = double.Parse(InputTxt);
            

            double result = calcmodel.PerformCalculation(firstNum, secondNum, Operation);

            InputTxt = result.ToString();
        }
    }
}
