using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Lp1_Clase01
{
    public partial class Form1 : Form
    {
        public double resultadoAEnviar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado=0;

            switch (comboBox1.Text)
            {
                case "Suma": resultado = double.Parse(tbNumero1.Text) + double.Parse(tbNumero2.Text); ;
                    break;
                case "Resta":
                    resultado = double.Parse(tbNumero1.Text) - double.Parse(tbNumero2.Text); ;
                    break;
                case "Multiplicacion":
                    resultado = double.Parse(tbNumero1.Text) * double.Parse(tbNumero2.Text); ;
                    break;
                case "Division":
                    resultado = double.Parse(tbNumero1.Text) / double.Parse(tbNumero2.Text); ;
                    break;
                case "Factorial Numero 1":
                    resultado = factorial(double.Parse(tbNumero1.Text)) ;
                    break;
            }
            resultadoAEnviar = resultado;
            MessageBox.Show("El resultado es " + resultado.ToString());
        }

        private double factorial(double n) { 
            double resultado = 1;
            for(int i = 1; i < n+1;i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Suma":
                    label3.Text="+";
                    break;
                case "Resta":
                    label3.Text = "-";
                    break;
                case "Multiplicacion":
                    label3.Text = "x";
                    break;
                case "Division":
                    label3.Text = "%";
                    break;
                case "Factorial Numero 1":
                    tbNumero2.Visible = false;
                    label2.Visible = false;
                    break;
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultadoAEnviar != null)
            {
                Form2 form2 = new Form2(resultadoAEnviar);
                form2.Show();
                this.Hide();
            }
        }
    }
}
