﻿using System;
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
            _textBox.Text = _model.GetCurrentValue().ToString();
        }

        /// <summary>
        /// event while clicking numBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void NumberButtonClick(object sender, EventArgs e, int value)
        {
            _model.SetCurrentValue(value, false);
            _textBox.Text = _model.GetCurrentValue().ToString();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="value"></param>
        private void OperationButtonClick(object sender, EventArgs e, string value)
        {
        }
    }
}
