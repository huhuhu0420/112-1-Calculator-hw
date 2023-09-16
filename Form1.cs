using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _model = new Model();
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// event while clicking equalBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButtonClick(object sender, EventArgs e)
        {
            _textBox.Text = _model.GetScreenValue().ToString();
        }

        /// <summary>
        /// event while clicking numBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void NumberButtonClick(object sender, EventArgs e, int value)
        {
            _model.SetScreenValue(value.ToString());
        }
    }

    public partial class Model
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
        /// <param name="s"></param>
        public void SetScreenValue(String value)
        {
            _screenValue = value;
        }

        private string _screenValue = "0";

    }
}
