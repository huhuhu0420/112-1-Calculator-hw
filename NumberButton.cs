namespace WindowsFormsApp1
{
    public class NumberButton : System.Windows.Forms.Button
    {
        public NumberButton() : base()
        {

        }
        /// <summary>
        /// setter
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(int value)
        {
            _value = value;
        }

        /// <summary>
        /// getter
        /// </summary>
        /// <returns></returns>
        public int GetValue()
        {
            return _value;
        }

        private int _value = 0;
    }
}