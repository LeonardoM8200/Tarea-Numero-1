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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btnsumadetres_Click(object sender, EventArgs e)
        {
            Formularios.frmsumadetres suma = new frmsumadetres();
            suma.ShowDialog();
        }

        private void btnpromeio_Click(object sender, EventArgs e)
        {
            Formularios.frmpromedio promedio = new frmpromedio();
            promedio.ShowDialog();

        }

        private void btnmillasametros_Click(object sender, EventArgs e)
        {
            Formularios.frmmillasandmetros millasametros = new frmmillasandmetros();
            millasametros.ShowDialog();
        }

        private void btnmillas_Click(object sender, EventArgs e)
        {
            Formularios.frmmillasandkilometros millasakilometros = new frmmillasandkilometros();
            millasakilometros.ShowDialog();
        }

        private void btnlempirasadolares_Click(object sender, EventArgs e)
        {
            Formularios.frmlempirasanddolares lempirasydolar = new frmlempirasanddolares();
            lempirasydolar.ShowDialog();
        }

        private void btneurosalempiras_Click(object sender, EventArgs e)
        {
            Formularios.frmlempirasandeuros lempirayeuro = new frmlempirasandeuros();
            lempirayeuro.ShowDialog();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Formularios.frmcompradellantas llantas = new frmcompradellantas();
            llantas.ShowDialog();
        }

        private void btnsalario_Click(object sender, EventArgs e)
        {
            Formularios.frmsalario salario = new frmsalario();
            salario.ShowDialog();
        }

        private void btnsalarioxhoraextra_Click(object sender, EventArgs e)
        {
            Formularios.frmsalarioxhoraextra salarioxhora =new frmsalarioxhoraextra();
            salarioxhora.ShowDialog();
        }

        private void btngalonesalts_Click(object sender, EventArgs e)
        {
            Formularios.frmgalonesandlitros galonesxlitros = new frmgalonesandlitros();
            galonesxlitros.ShowDialog();
        }

        private void btnautor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos A Mi Programa, Edwin Leonardo Molina");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
