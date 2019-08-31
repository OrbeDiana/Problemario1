using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operación;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ".";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 1)
            {
                Screen.Text = "";
            }
            else
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            operación = "/";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            operación = "-";
            primero = double.Parse(Screen.Text);
            Screen.Clear();

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            operación = "*";
            primero = double.Parse(Screen.Text);
            Screen.Clear();

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            operación = "+";
            primero = double.Parse(Screen.Text);
            Screen.Clear();

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Screen.Text);
            switch (operación)
            {
                case "+":
                    resultado = primero + segundo;
                    Screen.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    Screen.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    Screen.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    Screen.Text = resultado.ToString();
                    break;

                case "%":
                    resultado = primero / 100 * segundo;
                    Screen.Text = resultado.ToString();
                    break;

            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            operación = "%";
            primero = double.Parse(Screen.Text);
            Screen.Clear();

        }
    }
}
