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
    public partial class frmgalonesandlitros : Form
    {
        public frmgalonesandlitros()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtgalones.Clear();
            txtlitros.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double galones, litros;
            galones = int.Parse(txtgalones.Text);
            litros = galones * 3.78541;
            txtlitros.Text = litros.ToString();
        }
    }
}
