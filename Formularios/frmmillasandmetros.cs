using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_LeonardoMolina.Formularios
{
    public partial class frmmillasandmetros : Form
    {
        public frmmillasandmetros()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double millas, resultado;
            millas = int.Parse(txtmillas.Text);

            resultado = millas * 1609.34;

            txtmetros.Text = resultado.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtmetros.Clear();
            txtmillas.Clear();
        }
    }
}
