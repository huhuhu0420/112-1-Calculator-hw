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
            if (_isDecimal)
            {
                _decimalCounter++;
                _inputValue += value / (Math.Pow(TEN, _decimalCounter));
            }
            else
            {
                _inputValue = _inputValue * int.Parse(TEN.ToString()) + value;
            }
            PrintLog();
        }

        /// <summary>
        /// clear input
        /// </summary>
        private void ClearInputValue()
        {
            _inputValue = 0;
            PrintLog();
        }

        /// <summary>
        /// clear result
        /// </summary>
        private void ClearResultValue()
        {
            _resultValue = 0;
        }

        /// <summary>
        /// clear operation
        /// </summary>
        private void ClearOperation()
        {
            _operator = PLUS;
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
                PrintLog();
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
                return _operator;
            }
            set
            {
                _operator = value;
                PrintLog();
            }
        }

        /// <summary>
        /// calculate
        /// </summary>
        public void Calculate()
        {
            switch (_operator)
            {
                case PLUS:
                    ResultValue += _inputValue;
                    break;
                case MINUS:
                    ResultValue -= _inputValue;
                    break;
                case MULTIPLY:
                    ResultValue *= _inputValue;
                    break;
                case DIVIDE:
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
            ActivateDecimal(false);
        }
        
        /// <summary>
        /// handle click
        /// </summary>
        /// <param name="value"></param>
        public void HandleNumberButtonClick(int value)
        {
            if (LastInput == InputType.Equal)
            {
                ClearInputValue();
                ClearResultValue();
                ClearOperation();
            }
            AddInputValue(value);
            LastInput = InputType.Number;
        }

        /// <summary>
        /// process
        /// </summary>
        /// <param name="value"></param>
        private void Process(string value)
        {
            switch (LastInput)
            {
                case InputType.Equal:
                    ClearInputValue();
                    break;
                case InputType.Number:
                    Calculate();
                    ClearInputValue();
                    break;
                case InputType.Operation:
                    Operation = value;
                    break;
                case InputType.ClearEntry:
                    Operation = value;
                    break;
            }
        }
        
        /// <summary>
        /// handle click
        /// </summary>
        /// <param name="value"></param>
        public void HandleOperationButtonClick(string value)
        {
            Process(value);
            Operation = value;
            LastInput = InputType.Operation;
            ActivateDecimal(false);
        }
        
        /// <summary>
        /// dot btn click
        /// </summary>
        public void HandleDotButtonClick()
        {
            ActivateDecimal(true);
        }

        /// <summary>
        /// ce btn click
        /// </summary>
        public void HandleClearEntryButtonClick()
        {
            ClearInputValue();
            ActivateDecimal(false);
            LastInput = InputType.ClearEntry;
        }

        /// <summary>
        /// c btn click
        /// </summary>
        public void HandleClearButtonClick()
        {
            ClearInputValue();
            ClearOperation();
            ClearResultValue();
            ActivateDecimal(false);
        }

        /// <summary>
        /// activate decimal
        /// </summary>
        public void ActivateDecimal(bool activate)
        {
            if (activate)
            {
                _isDecimal = true;
            }
            else
            {
                _decimalCounter = 0;
                _isDecimal = false;
            }   
        }

        /// <summary>
        /// print debug
        /// </summary>
        private void PrintLog()
        {
            // Debug.WriteLine("input: ".ToString() + _inputValue.ToString() + " | ".ToString() + "result: ".ToString() + _resultValue.ToString() + " | ".ToString() + "operation: ".ToString() + _operator);
        }

        private double _resultValue = 0;
        private double _inputValue = 0;
        private string _operator = PLUS;
        private bool _isDecimal = false;
        private int _decimalCounter = 0;
        // private InputType _lastInput = InputType.Number;

        const string PLUS = "+";
        const string MINUS = "-";
        const string MULTIPLY = "×";
        const string DIVIDE = "÷";
        const int TEN = 10;

        public enum InputType
        {
            Number, 
            Operation,
            Equal,
            ClearEntry
        }
    }
}