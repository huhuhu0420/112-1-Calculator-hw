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
            model = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = model.GetResult().ToString();
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = model.GetResult().ToString();
        }
    }

    public partial class Model
    {
        public Model() { }
        public double GetResult()
        { 
        
            return result;
        }

        private double result = 0;
        private double[] nums = { 0, 0 };

    }
}
