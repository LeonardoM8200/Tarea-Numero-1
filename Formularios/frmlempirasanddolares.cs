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
    public partial class frmlempirasanddolares : Form
    {
        public frmlempirasanddolares()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double lempiras, resultado;

            lempiras = int.Parse(txtlempiras.Text);
            resultado = lempiras / 24.61;
            txtdolares.Text = resultado.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdolares.Clear();
            txtlempiras.Clear();
        }
    }
}
