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
    public partial class frmpromedio : Form
    {
        public frmpromedio()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4, promedio;
            nota1 = int.Parse(txtnota1.Text);
            nota2 = int.Parse(txtnota2.Text);
            nota3 = int.Parse(txtnota3.Text);
            nota4 = int.Parse(txtnota4.Text);
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            txtpromedio.Text = promedio.ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtpromedio.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
