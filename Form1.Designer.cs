
using System;
using System.Collections.Generic;
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
            this._plusButton = new System.Windows.Forms.Button();
            this._equalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this._textBox.Location = new System.Drawing.Point(493, 75);
            this._textBox.Name = "textBox";
            this._textBox.Size = new System.Drawing.Size(100, 22);
            this._textBox.TabIndex = 0;
            this._textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // nums
            //
            for (int i = 0; i < 10; i++)
            {
                System.Windows.Forms.Button num = new System.Windows.Forms.Button();
                num.Location = new System.Drawing.Point(450 + 65 * (i % 3), 140 + 57 * (i / 3));
                num.Name = "numBtn" + i.ToString();
                num.Size = new System.Drawing.Size(62, 54);
                num.TabIndex = 1;
                num.Text = i.ToString();
                num.UseVisualStyleBackColor = true;
                num.Click += (sender, e) => NumberButtonClick(sender, e, int.Parse(num.Text));
                this._numberButtons.Add(num);
            }
            // 
            // plusBtn
            // 
            this._plusButton.Location = new System.Drawing.Point(688, 240);
            this._plusButton.Name = "plusBtn";
            this._plusButton.Size = new System.Drawing.Size(62, 54);
            this._plusButton.TabIndex = 1;
            this._plusButton.Text = "+";
            this._plusButton.UseVisualStyleBackColor = true;
            // 
            // equalBtn
            // 
            this._equalButton.Location = new System.Drawing.Point(688, 312);
            this._equalButton.Name = "equalBtn";
            this._equalButton.Size = new System.Drawing.Size(62, 54);
            this._equalButton.TabIndex = 1;
            this._equalButton.Text = "=";
            this._equalButton.UseVisualStyleBackColor = true;
            this._equalButton.Click += new System.EventHandler(this.EqualButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._equalButton);
            this.Controls.Add(this._plusButton);
            this.Controls.Add(this._textBox);
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add((this._numberButtons[i]));
            }
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox _textBox;
        private List<System.Windows.Forms.Button> _numberButtons;
        private System.Windows.Forms.Button _plusButton;
        private System.Windows.Forms.Button _equalButton;
        private Model _model;

    }
}

