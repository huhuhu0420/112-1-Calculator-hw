
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._textBox = new System.Windows.Forms.TextBox();
            this._numberButtons = new List<System.Windows.Forms.Button>();
            this._operatorButtons= new List<System.Windows.Forms.Button>();
            this._equalButton = new System.Windows.Forms.Button();
            this._dotButton = new Button();
            this._clearEntryButton = new Button();
            this._clearButton = new Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this._textBox.Location = new System.Drawing.Point(10, 32);
            this._textBox.Name = "textBox";
            this._textBox.Size = new System.Drawing.Size(250, 22);
            this._textBox.TabStop = false;
            this._textBox.Font = new Font(_textBox.Font.FontFamily, 16);
            this._textBox.ReadOnly = true;
            this._textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // nums
            //
            int[] numbers = new[] { 7, 8, 9, 4, 5, 6, 1, 2, 3, 0 };
            for (int i = 0; i < 10; i++)
            {
                System.Windows.Forms.Button num = new System.Windows.Forms.Button();
                num.Location = new System.Drawing.Point(10 + 65 * (i % 3), 140 + 57 * (i / 3));
                num.Name = "numBtn" + numbers[i].ToString();
                num.Size = new System.Drawing.Size(62, 54);
                num.TabIndex = 1;
                num.Text = numbers[i].ToString();
                num.UseVisualStyleBackColor = true;
                num.Click += (sender, e) => NumberButtonClick(int.Parse(num.Text));
                this._numberButtons.Add(num);
                this.Controls.Add((this._numberButtons[i]));
            }
            //
            // operationButton
            //
            string[] operators = { "+", "-", "×", "÷" };
            for (int i = 0; i < 4; i++)
            {
                System.Windows.Forms.Button operatorButton = new System.Windows.Forms.Button();
                operatorButton.Location = new System.Drawing.Point(205, 140 + 57 * i);
                operatorButton.Name = "operationBtn" + i.ToString();
                operatorButton.Size = new System.Drawing.Size(62, 54);
                operatorButton.TabIndex = 1;
                operatorButton.Text = operators[i];
                operatorButton.UseVisualStyleBackColor = true;
                operatorButton.Click += (sender, e) => ClickOperatorButton(operatorButton.Text);
                this._operatorButtons.Add(operatorButton);
                this.Controls.Add((this._operatorButtons[i]));
            }
            // 
            // equalBtn
            // 
            this._equalButton.Location = new System.Drawing.Point(140, 312);
            this._equalButton.Name = "equalBtn";
            this._equalButton.Size = new System.Drawing.Size(62, 54);
            this._equalButton.TabIndex = 1;
            this._equalButton.Text = "=";
            this._equalButton.UseVisualStyleBackColor = true;
            this._equalButton.Click += (sender, e) => this.EqualButtonClick();
            // 
            // dot 
            // 
            this._dotButton.Location = new System.Drawing.Point(75, 311);
            this._dotButton.Name = "dotBtn";
            this._dotButton.Size = new System.Drawing.Size(62, 54);
            this._dotButton.TabIndex = 1;
            this._dotButton.Text = ".";
            this._dotButton.UseVisualStyleBackColor = true;
            this._dotButton.Click += (sender, e) => this.DotButtonClick();
            // 
            // ce
            // 
            this._clearEntryButton.Location = new System.Drawing.Point(140, 83);
            this._clearEntryButton.Name = "ceBtn";
            this._clearEntryButton.Size = new System.Drawing.Size(62, 54);
            this._clearEntryButton.TabIndex = 1;
            this._clearEntryButton.Text = "ce";
            this._clearEntryButton.UseVisualStyleBackColor = true;
            this._clearEntryButton.Click += (sender, e) => this.ClearEntryButtonClick();
            // 
            // c
            // 
            this._clearButton.Location = new System.Drawing.Point(205, 83);
            this._clearButton.Name = "cBtn";
            this._clearButton.Size = new System.Drawing.Size(62, 54);
            this._clearButton.TabIndex = 1;
            this._clearButton.Text = "c";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += (sender, e) => this.ClearButtonClick();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 375);
            this.Controls.Add(this._equalButton);
            this.Controls.Add(this._dotButton);
            this.Controls.Add(this._clearButton);
            this.Controls.Add(this._clearEntryButton);
            this.Controls.Add(this._textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox _textBox;
        private List<System.Windows.Forms.Button> _numberButtons;
        private List<System.Windows.Forms.Button> _operatorButtons;
        private System.Windows.Forms.Button _equalButton;
        private System.Windows.Forms.Button _dotButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.Button _clearEntryButton;
        private Model _model;
        
    }
}

