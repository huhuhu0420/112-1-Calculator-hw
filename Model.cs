﻿using System;
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
            _inputValue = _inputValue * int.Parse(10.ToString()) + value;
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
                return _operation;
            }
            set
            {
                _operation = value;
                PrintLog();
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
                ClearInputValue();
                ClearResultValue();
                ClearOperation();
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
                    ClearInputValue();
                    break;
                case InputType.Number:
                    Calculate();
                    ClearInputValue();
                    break;
                case InputType.Operation:
                    Operation = value;
                    break;
            }
            Operation = value;
            LastInput = InputType.Operation;
        }

        /// <summary>
        /// ce btn click
        /// </summary>
        public void HandleClearEntryButtonClick()
        {
            ClearInputValue();
        }

        /// <summary>
        /// c btn click
        /// </summary>
        public void HandleClearButtonClick()
        {
            ClearInputValue();
            ClearOperation();
            ClearResultValue();
        }

        /// <summary>
        /// print debug
        /// </summary>
        private void PrintLog()
        {
            Debug.WriteLine("input: ".ToString()+ _inputValue.ToString() + " | ".ToString() + "result: ".ToString() + _resultValue.ToString() + " | ".ToString() + "operation: ".ToString() + _operation);
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
            Equal
        }
    }
}