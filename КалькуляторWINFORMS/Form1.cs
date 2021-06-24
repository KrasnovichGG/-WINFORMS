using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КалькуляторWINFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ToolTip toolTip1 = new ToolTip();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void boxlabel1_TextChanged(object sender, EventArgs e)
        {
        }

        private void boxlabel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnschot_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(boxlabel1.Text);
            b = Convert.ToDouble(boxlabel2.Text);
            switch (comboBox1.Text)
            {
                case "+Сложение":
                    boxresult.Text = Convert.ToString(a + b);
                    break;
                case "-Вычитание":
                    boxresult.Text = Convert.ToString(a - b);
                    break;
                case "*Умножение":
                    boxresult.Text = Convert.ToString(a * b);
                    break;
                case "/Деление":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль нельзя делить!");
                    }
                    boxresult.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            boxlabel1.Text = "";
            boxlabel2.Text = "";
            boxresult.Text = "";
            comboBox1.Text = "";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
