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
    public partial class frmsalario : Form
    {
        public frmsalario()
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
            txtganancia.Clear();
            txtsalario.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double salario, dias, total;
            salario = int.Parse(txtsalario.Text);
            dias = int.Parse(txtdiastrabajados.Text);
            total = salario * dias;
            txtganancia.Text = total.ToString();
        }
    }
}
