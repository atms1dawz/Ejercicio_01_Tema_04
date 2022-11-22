using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01_Tema_04
{
    public partial class Form1_Ejercicio_01_Tema_04 : Form
    {
        public Form1_Ejercicio_01_Tema_04()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            try
            {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            
            int resultadoFinal = suma(num1, num2);

            lblResultado.Text = resultadoFinal.ToString();

            }
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message);
            }
        }

        int suma (int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }
    }
}
