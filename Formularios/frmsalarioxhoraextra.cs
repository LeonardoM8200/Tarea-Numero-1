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
    public partial class frmsalarioxhoraextra : Form
    {
        public frmsalarioxhoraextra()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdiastrabajados.Clear();
            txthorasextras.Clear();
            txtpagoxdia.Clear();
            txttotal.Clear();
            txtpagoxhora.Clear();
            txtpagoxhoraextra.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double pagoxdia, pagoxhora, horasextras, pagoxhoraextra, diastrabajados, total;
            pagoxdia = int.Parse(txtpagoxdia.Text);
            pagoxhora = int.Parse(txtpagoxhora.Text);
            horasextras = int.Parse(txthorasextras.Text);
            pagoxhoraextra = pagoxhora * horasextras * 2;
            txtpagoxhoraextra.Text = pagoxhoraextra.ToString();
            diastrabajados = int.Parse(txtdiastrabajados.Text);
            total = pagoxdia * diastrabajados + pagoxhoraextra;
            txttotal.Text = total.ToString();
        }
    }
}
