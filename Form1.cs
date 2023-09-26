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
        public Form1(Model model)
        {
            InitializeComponent();
            _model = model;
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
        private void EqualButtonClick()
        {
            _model.HandleEqualButtonClick();
            _textBox.Text = _model.ResultValue.ToString();
        }

        /// <summary>
        /// event while clicking dotBtn 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButtonClick()
        {
            _model.HandleDotButtonClick();
        }

        /// <summary>
        /// ce btn click
        /// </summary>
        private void ClearEntryButtonClick()
        {
            _model.HandleClearEntryButtonClick();
            _textBox.Text = _model.GetInputValue().ToString();
        }

        /// <summary>
        /// c btn click
        /// </summary>
        private void ClearButtonClick()
        {
            _model.HandleClearButtonClick();
            _textBox.Text = _model.GetInputValue().ToString();
        }

        /// <summary>
        /// event while clicking numBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void NumberButtonClick(int value)
        {
            _model.HandleNumberButtonClick(value);
            _textBox.Text = _model.GetInputValue().ToString();
        }

        /// <summary>
        /// event while clicking operationBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void ClickOperatorButton(string value)
        {
            _model.HandleOperationButtonClick(value);
            _textBox.Text = _model.ResultValue.ToString();
        }
    }
}
