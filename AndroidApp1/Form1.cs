using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            //botom suma
            operacion = 1;
            valor1 = Convert.ToDouble(btncaja.Text);
            btncaja.Text = "";
        }

        private void btnmultiplicasion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(btncaja.Text);
            btncaja.Text = "";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //botom resta
            operacion = 2;
            valor1 = Convert.ToDouble(btncaja.Text);
            btncaja.Text = "";
        }

        private void btndivicion_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(btncaja.Text);
            btncaja.Text = "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            btncaja.Text = btncaja.Text + "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            btncaja.Text = btncaja.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            btncaja.Text = btncaja.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            btncaja.Text = btncaja.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            btncaja.Text = btncaja.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            btncaja.Text = btncaja.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            btncaja.Text = btncaja.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            btncaja.Text = btncaja.Text + "6";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            btncaja.Text = btncaja.Text + ".";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            //botn igual
            valor2 = Convert.ToDouble(btncaja.Text);

            switch(operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }

            btncaja.Text = resultado.ToString();
        }

        private void btncaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            //numero 8
            btncaja.Text = btncaja.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            btncaja.Text = btncaja.Text + "9";
        }

        private void btnlimpia_Click(object sender, EventArgs e)
        {
            //limpiar 
            btncaja.Text = "";
        }
    }
}
