
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.nums = new NumBtn[10];
            this.plusBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(493, 75);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 22);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // nums
            //
            for (int i = 0; i < 10; i++)
            {
                this.nums[i] = new NumBtn();
                this.nums[i].Location = new System.Drawing.Point(450 + 65 * (i % 3), 140 + 57 * (i / 3));
                this.nums[i].Name = "numBtn" + i.ToString();
                this.nums[i].Size = new System.Drawing.Size(62, 54);
                this.nums[i].TabIndex = 1;
                this.nums[i].Text = i.ToString();
                this.nums[i].UseVisualStyleBackColor = true;
            }
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(688, 240);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(62, 54);
            this.plusBtn.TabIndex = 1;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(688, 312);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(62, 54);
            this.equalBtn.TabIndex = 1;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.textBox);
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add((this.nums[i]));
            }
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private NumBtn[] nums;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button equalBtn;
        private Model model;

    }

    public class NumBtn : System.Windows.Forms.Button
    {
        public NumBtn() : base()
        {

        }

        public void SetValue (int v)
        {
            value = v;
        }

        private int value = 0;
    }
}

