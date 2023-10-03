using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySeguros
{
    public partial class frmPlanilla : Form
    {
        StreamReader objetoLectorArchivo;
        StreamWriter objetoEscribeArchivo;
        string rutaArchivo;

        string leerLinea;
        string[] separadorTexto;

        
        



    
         public frmPlanilla()
         {
             InitializeComponent();
         }

         private void frmPlanilla_Load(object sender, EventArgs e)
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
                dgvPlanilla.Rows.Add(separadorTexto);
            }

            objetoLectorArchivo.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DirectoryInfo informacionCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = informacionCarpetas.FullName;

            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            objetoEscribeArchivo = new StreamWriter(rutaArchivo, true);

            objetoEscribeArchivo.WriteLine(txtNumero.Text + ";" + txtEntidad.Text + ";"
                + txtApertura.Text + ";" + txtExpediente.Text + ";" + txtJuzg + ";"
                + txtJurisdiccion + ";" + txtDireccion + ";" + txtLiquidador);

            objetoEscribeArchivo.Close();

            MessageBox.Show("Registrado Correctamente");
        }

        private void dgvPlanilla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = dgvPlanilla.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEntidad.Text = dgvPlanilla.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApertura.Text = dgvPlanilla.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExpediente.Text = dgvPlanilla.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtJuzg.Text = dgvPlanilla.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtJurisdiccion.Text = dgvPlanilla.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvPlanilla.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLiquidador.Text = dgvPlanilla.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnModificar_Click(object sender,EventArgs  e)
        {
           




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
           // if (txtBusqueda.Text != "") 
            {
               // dgvPlanilla.CurrentCell = null;
            
                //foreach(DataGridViewRow F in dgvPlanilla.Rows) 
                {
                
                  //  F.Visible = false;
                
                }
                //foreach (DataGridViewRow F in dgvPlanilla.Rows) 
                {
                
                   // foreach(DataGridViewCell C in F.Cells) 
                    {
                      //  if ((C.Value.ToString().ToUpper()).IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                           // F.Visible = true;
                            //break;
                        
                        }
                        
                    
                    }
                
                
                }


            }
            //else 
            { 
              
            }
        }
    }
}
