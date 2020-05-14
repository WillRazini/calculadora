using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_01
{
    public partial class Form1 : Form
    {
        string operador;
        double num1, num2, resultado;
        Boolean ban_btn = true, ban_num = true, ban_ope = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "0";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "0";
            }
            ban_btn = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "1";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "1";
            }
            ban_btn = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "2";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "2";
            }
            ban_btn = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "3";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "3";
            }
            ban_btn = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "4";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "4";
            }
            ban_btn = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "5";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "5";
            }
            ban_btn = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "6";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "6";
            }
            ban_btn = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "7";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "7";
            }
            ban_btn = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "8";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "8";
            }
            ban_btn = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                Exibir.Clear();
                Exibir.Text = "9";
                ban_num = false;
            }
            else
            {
                Exibir.Text = Exibir.Text + "9";
            }
            ban_btn = false;
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            Exibir.Text = Exibir.Text + ".";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            Exibir.Clear();
            ban_num = true;
            ban_ope = true;
            ban_btn = true;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (Exibir.TextLength > 1)
            {
                Exibir.Text = Exibir.Text.Remove(Exibir.Text.Length - 1, 1);
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            operador = "-";
            ban_num = true;
            if (ban_btn == false)
            {
                num1 = double.Parse(Exibir.Text);
                Exibir.Clear();
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            operador = "*";
            ban_num = true;
            if (ban_btn == false)
            {
                num1 = double.Parse(Exibir.Text);
                Exibir.Clear();
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            ban_num = true;
            if(ban_btn == false)
            {
                num1 = double.Parse(Exibir.Text);
                Exibir.Clear();
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            ban_num = true;
            if (ban_btn == false)
            {
                num2 = double.Parse(Exibir.Text);
            }

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            Exibir.Text = resultado.ToString();
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            operador = "+";
            ban_num = true;
            if (ban_btn == false)
            {
                num1 = double.Parse(Exibir.Text);
                Exibir.Clear();
            }
        }
    }
}
