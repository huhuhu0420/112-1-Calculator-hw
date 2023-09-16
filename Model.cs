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
        public double GetCurrentValue()
        {
            return _currentValue;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="value"></param>
        public void SetCurrentValue(int value, bool isClear)
        {
            if (!isClear)
            {
                _currentValue = _currentValue * 10 + value;
            }
            else
            {
                _currentValue = 0;
            }
        }

        private double _currentValue = 0;
        private double _calculateValue = 0;
        private string _operator = "";
    }
}