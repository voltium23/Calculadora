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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        static String valor;
        static int sw = 0;
        static float total = 0;
        static int opcActual = 0;
        static int opcAnterior = 0;
        static int swd = 0;

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero.Text = "";
            sw = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "1";
            numero.Text = valor;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "2";
            numero.Text = valor;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "3";
            numero.Text = valor;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "4" + "";
            numero.Text = valor;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "5";
            numero.Text = valor;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "6";
            numero.Text = valor;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "7";
            numero.Text = valor;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "8";
            numero.Text = valor;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "9";
            numero.Text = valor;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            validar();
            valor = valor + "0";
            numero.Text = valor;
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            sw = 1;
            swd = 0;
           if (opcActual == 0 && opcAnterior == 0)
            {
                opcActual = 1;
                opcAnterior = 1;
            }
            opcAnterior = opcActual;
            opcActual = 1;
            Operacion(valor);
        }

        private void Operacion(String val)
        {
            switch (opcAnterior)
            {
                case 1:
                    total = total + Convert.ToSingle(val);
                    break;
                case 2:
                    if (total == 0)
                    {
                        total = Convert.ToSingle(val);
                    }
                    else
                    {
                        total = total - Convert.ToSingle(val);
                    }
                    break;
                case 3:
                    if (total == 0)
                    {
                        total = Convert.ToSingle(val);
                    }
                    else
                    {
                        total = total * Convert.ToSingle(val);
                    }
                    break;
                case 4:
                    if (total == 0)
                    {
                        total = Convert.ToSingle(val);
                    }
                    else
                    {
                        total = total / Convert.ToSingle(val);
                    }
                    break;
            }
            numero.Text = Convert.ToString(total);
        }

        static void validar()
        {
            if (sw == 1)
            {
                valor = "";
                sw = 0;
            }
        }

        private void bresta_Click(object sender, EventArgs e)
        {
            sw = 1;
            swd = 0;
            if (opcActual == 0 && opcAnterior == 0)
            {
                opcActual = 2;
                opcAnterior = 2;
            }
            opcAnterior = opcActual;
            opcActual = 2;
            Operacion(valor);
        }

        private void bmultiplicacion_Click(object sender, EventArgs e)
        {
            sw = 1;
            swd = 0;
            if (opcActual == 0 && opcAnterior == 0)
            {
                opcActual = 3;
                opcAnterior =3;
            }
            opcAnterior = opcActual;
            opcActual = 3;
            Operacion(valor);
        }

        private void bdivision_Click(object sender, EventArgs e)
        {
            sw = 1;
            swd = 0;
            if (opcActual == 0 && opcAnterior == 0)
            {
                opcActual = 4;
                opcAnterior = 4;
            }
            opcAnterior = opcActual;
            opcActual = 4;
            Operacion(valor);
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            sw = 1;
            swd = 0;
            opcAnterior = opcActual;
            Operacion(valor);
            valor = "0";
        }

        private void bdecimal_Click(object sender, EventArgs e)
        {
            if (swd == 0)
            {
                swd = 1;
                valor = valor + ",";
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {
            sw = 0;
            swd = 0;
            opcActual = 0;
            opcAnterior = 0;
            total = 0;
            valor = "";
            numero.Text = "";
        }

        private void bretroceso_Click(object sender, EventArgs e)
        {
            if (valor.Length != 0)
            {
                valor = valor.Substring(0, valor.Length - 1);
                numero.Text = valor;
            }
            else
            {
                numero.Text = "0";
            }
        }

        private void bsigno_Click(object sender, EventArgs e)
        {
            float num = Convert.ToSingle(valor) * (-1);
            valor = Convert.ToString();
        }
    }
}
