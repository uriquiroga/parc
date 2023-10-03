using System;
using System.IO;
using System.Windows.Forms;

namespace prySeguros
{
    public partial class frmProveedores : Form
    {
        StreamReader objetoLectorArchivo;
        StreamWriter objetoEscribeArchivo;
        string rutaArchivo;

        string leerLinea;
        string[] separadorTexto;

        public frmProveedores()
        {
            InitializeComponent();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";
           
            objetoLectorArchivo = new StreamReader(rutaArchivo);

            while (!objetoLectorArchivo.EndOfStream)
            {
                leerLinea = objetoLectorArchivo.ReadLine();

                separadorTexto = leerLinea.Split(';');

                //lblDatos.Text+=objetoLectorArchivo.ReadLine();
                dgvDatos.Rows.Add(separadorTexto);
            }

            objetoLectorArchivo.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            objetoEscribeArchivo = new StreamWriter(rutaArchivo, true);

            objetoEscribeArchivo.WriteLine(txtNumero.Text + ";" + txtEntidad.Text + ";" 
                +txtApertura.Text + ";" + txtExpediente.Text + ";"  +txtJuzg + ";" 
                + txtJurisdiccion + ";"+txtDireccion + ";" +  txtLiquidador);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registrado Correctamente");

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                lblDobleClick.Text = "hizo doble clic";

                txtNumero.Text = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEntidad.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtApertura.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtExpediente.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtJuzg.Text = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtJurisdiccion.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDireccion.Text = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtLiquidador.Text = dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();
            
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDobleClick_Click(object sender, EventArgs e)
        {

        }
    }
}
