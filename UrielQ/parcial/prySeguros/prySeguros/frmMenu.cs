using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySeguros
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Form formularioProveedores = new frmProveedores();
            formularioProveedores.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Form formularioListado = new frmListado();
            formularioListado.Show();
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            Form formularioPlanilla = new frmPlanilla();
            formularioPlanilla.Show();
        }

        private void btnBasedatos_Click(object sender, EventArgs e)
        {
            Form formularioBaseDatos = new frmCarpetas();
            formularioBaseDatos.Show();
        }
    }
    
}
