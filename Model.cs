using System;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public class Model
    {
        public Model()
        { 
        }
        
        /// <summary>
        /// getter
        /// </summary>
        /// <returns></returns>
        public double GetInputValue()
        {
            return _inputValue;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="value"></param>
        public void AddInputValue(int value)
        {
            _inputValue = _inputValue * 10 + value;
            debugLog();
        }

        /// <summary>
        /// clear input
        /// </summary>
        public void ClearInputValue()
        {
            _inputValue = 0;
            debugLog();
        }

        public double ResultValue
        {
            get
            {
                return _resultValue;
            }
            set
            {
                _resultValue = value;
                debugLog();
            }
        }

        public InputType LastInput
        {
            get;
            set;
        }

        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;
                debugLog();
            }
        }

        /// <summary>
        /// calculate
        /// </summary>
        public void Calculate()
        {
            switch (_operation)
            {
                case "+":
                    ResultValue += _inputValue;
                    break;
                case "-":
                    ResultValue -= _inputValue;
                    break;
                case "×":
                    ResultValue *= _inputValue;
                    break;
                case "÷":
                    ResultValue /= _inputValue;
                    break;
                default:
                    break;
            }
        }

        private void debugLog()
        {
            Debug.WriteLine("input: "+ _inputValue.ToString() + " | " + "result: " + _resultValue.ToString() + " | " + "operation: " + _operation);
        }

        private double _resultValue = 0;
        private double _inputValue = 0;
        private string _operation = "";
        private InputType _lastInput = InputType.Number;

        public enum InputType
        {
            Number, 
            Operation,
            Equal,
        }
    }
}