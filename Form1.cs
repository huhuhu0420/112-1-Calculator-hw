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
            _model.Calculate();
            _textBox.Text = _model.ResultValue.ToString();
            _model.LastInput = Model.InputType.Equal;
        }

        /// <summary>
        /// event while clicking dotBtn 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButtonClick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// event while clicking numBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void NumberButtonClick(object sender, EventArgs e, int value)
        {
            _model.AddInputValue(value);
            _textBox.Text = _model.GetInputValue().ToString();
            _model.LastInput = Model.InputType.Number;
        }

        /// <summary>
        /// event while clicking operationBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void OperationButtonClick(object sender, EventArgs e, string value)
        {
            switch (_model.LastInput)
            {
                case Model.InputType.Equal:
                    _model.ClearInputValue();
                    break;
                case Model.InputType.Number:
                    if (_model.Operation != "")
                    {
                        _model.Calculate();
                        _textBox.Text = _model.ResultValue.ToString();
                    }
                    else
                    {
                        _model.ResultValue = _model.GetInputValue();
                    }
                    _model.ClearInputValue();
                    break;
                case Model.InputType.Operation:
                    _model.Operation = value;
                    break;
            }
            _model.Operation = value;
            _model.LastInput = Model.InputType.Operation;
        }
    }
}
