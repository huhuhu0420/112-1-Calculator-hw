using System;

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
        public double GetResultValue()
        {
            return _resultValue;
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
        /// <param name="calculateValue"></param>
        public void SetResultValue(double currentValue)
        {
            _resultValue = currentValue;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="value"></param>
        public void SetInputValue(int value, bool isClear)
        {
            if (!isClear)
            {
                _inputValue = _inputValue * 10 + value;
            }
            else
            {
                _inputValue = 0;
            }
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="???"></param>
        public void SetOperator(string operators)
        {
            _operator = operators;
        }

        /// <summary>
        /// calculate
        /// </summary>
        public void Calculate()
        {
            switch (_operator)
            {
                case "+":
                    _resultValue += _inputValue;
                    break;
                case "-":
                    _resultValue -= _inputValue;
                    break;
                case "×":
                    _resultValue *= _inputValue;
                    break;
                case "÷":
                    _resultValue /= _inputValue;
                    break;
            }
        }

        private double _resultValue = 0;
        private double _inputValue = 0;
        private string _operator = "";
    }
}