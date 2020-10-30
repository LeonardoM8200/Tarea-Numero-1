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
    public partial class frmmillasandkilometros : Form
    {
        public frmmillasandkilometros()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double millas, km;
            millas = int.Parse(txtmillas.Text);

            km = millas * 1.609;
            txtkilometros.Text = km.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtkilometros.Clear();
            txtmillas.Clear();
        }
    }
}
