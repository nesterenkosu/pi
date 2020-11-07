using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            if(tb_a.Text.Trim()=="" || tb_b.Text.Trim() == "")
            {
                lb_Result.Text = "ОШИБКА! Не все поля заполнены!";
                return;
            }

            int a, b;

            try
            {
                a = Convert.ToInt32(tb_a.Text);
                b = Convert.ToInt32(tb_b.Text);
            }
            catch(System.FormatException)
            {
                lb_Result.Text = "ОШИБКА! Введены недопустимые символы!";
                return;
            }

            if (b == 0)
            {
                lb_Result.Text = "ОШИБКА! Деление на ноль!";
                return;
            }

            lb_Result.Text = (a / b).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
