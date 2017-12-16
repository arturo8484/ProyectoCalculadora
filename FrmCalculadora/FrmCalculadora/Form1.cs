using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalculadora
{
    public partial class Form1 : Form
    {
        int primer_valor, segundo_valor,resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            segundo_valor = Convert.ToInt32(Screen_Calculadora.Text);
            switch (operacion) {
                case "+":
              resultado= primer_valor + segundo_valor;
              Screen_Calculadora.Text = resultado.ToString();
                    break;

                case "-":
              resultado= primer_valor - segundo_valor;
              Screen_Calculadora.Text = resultado.ToString();
                    break;
                case "x":
              resultado= primer_valor * segundo_valor;
              Screen_Calculadora.Text = resultado.ToString();
              break;  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Screen_Calculadora.Text = Screen_Calculadora.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Text = Screen_Calculadora.Text + "0";
        }

        private void Screen_Calculadora_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Screen_Calculadora.Clear();
        }

        private void Btn_suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primer_valor = Convert.ToInt32(Screen_Calculadora.Text);
            Screen_Calculadora.Clear();
        }

        private void Btn_resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primer_valor = Convert.ToInt32(Screen_Calculadora.Text);
            Screen_Calculadora.Clear();
        }

        private void Btn_multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primer_valor = Convert.ToInt32(Screen_Calculadora.Text);
            Screen_Calculadora.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // En propiedades se habilita KeyPreview: True para 
            //que podamos introducir numeros con el teclado
            switch (e.KeyChar.ToString())
            {
                case "0":
                    Btn_num0.PerformClick();
                    break;
                case "1":
                    Btn_num1.PerformClick();
                    break;
                case "2":
                    Btn_num2.PerformClick();
                    break;
                case "3":
                    Btn_num3.PerformClick();
                    break;
                case "4":
                    Btn_num4.PerformClick();
                    break;
                case "5":
                    Btn_num5.PerformClick();
                    break;
                case "6":
                    Btn_num6.PerformClick();
                    break;
                case "7":
                    Btn_num7.PerformClick();
                    break;
                case "8":
                    Btn_num8.PerformClick();
                    break;
                case "9":
                    Btn_num9.PerformClick();
                    break;
                    // Operaciones:
                case "+":
                    Btn_suma.PerformClick();
                    break;
                case "*":
                     Btn_multiplicacion.PerformClick();
                    break;
                case "-":
                    Btn_resta.PerformClick();
                    break;
           
            }
        }

       
    }
}
