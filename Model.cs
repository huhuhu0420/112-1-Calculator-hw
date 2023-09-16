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
        public string GetScreenValue()
        { 
            return _screenValue;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="value"></param>
        public void SetScreenValue(String value)
        {
            _screenValue = value;
        }

        private string _screenValue = "0";
    }
}