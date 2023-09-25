using System;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public class Model
    {
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
        private void clearInputValue()
        {
            _inputValue = 0;
            debugLog();
        }

        /// <summary>
        /// clear result
        /// </summary>
        private void clearResultValue()
        {
            _resultValue = 0;
        }

        /// <summary>
        /// clear operation
        /// </summary>
        private void clearOperation()
        {
            _operation = "+";
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
            }
        }

        /// <summary>
        /// handle click
        /// </summary>
        public void HandleEqualButtonClick()
        {
            Calculate();
            LastInput = InputType.Equal;
        }
        
        /// <summary>
        /// handle click
        /// </summary>
        /// <param name="value"></param>
        public void HandleNumberButtonClick(int value)
        {
            if (LastInput == InputType.Equal)
            {
                    clearInputValue();
                    clearResultValue();
                    clearOperation();
            }
            AddInputValue(value);
            LastInput = InputType.Number;
        }
        
        /// <summary>
        /// handle click
        /// </summary>
        /// <param name="value"></param>
        public void HandleOperationButtonClick(string value)
        {
            switch (LastInput)
            {
                case InputType.Equal:
                    clearInputValue();
                    break;
                case InputType.Number:
                    Calculate();
                    clearInputValue();
                    break;
                case InputType.Operation:
                    Operation = value;
                    break;
            }
            Operation = value;
            LastInput = InputType.Operation;
        }

        public void HandleCButtonClick()
        {
            clearInputValue();
        }

        /// <summary>
        /// print debug
        /// </summary>
        private void debugLog()
        {
            Debug.WriteLine("input: "+ _inputValue.ToString() + " | " + "result: " + _resultValue.ToString() + " | " + "operation: " + _operation);
        }

        private double _resultValue = 0;
        private double _inputValue = 0;
        private string _operation = "+";
        private bool _isDecimal = false;
        private InputType _lastInput = InputType.Number;

        public enum InputType
        {
            Number, 
            Operation,
            Equal,
        }
    }
}