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
    public partial class frmsumadetres : Form
    {
        public frmsumadetres()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3, resultado;
            numero1 = int.Parse(txtnum1.Text);
            numero2 = int.Parse(txtnum2.Text);
            numero3 = int.Parse(txtnum3.Text);
            resultado = numero1 + numero2 + numero3;
            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtnum3.Clear();
            txtresultado.Clear();


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
