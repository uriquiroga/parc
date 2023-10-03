using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Xml.Linq;

namespace prySeguros
{
    public partial class frmCarpetas : Form
    {
    

        string rutaArchivo;
        public frmCarpetas()
        {
            InitializeComponent();
        }

        private void btnBasedeDatos_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo("C:\\Users\\Usuario\\Desktop\\laboratorio\\parcial\\prySeguros\\prySeguros");
           

            CargarTreeview(info.FullName,info.Name);
        }

        private void TraerSubCarpetas(string ruta, TreeNode nodoRaiz)
        {
            try
            {
                string[] subCarpetas = Directory.GetDirectories(ruta);

                foreach (string subDirectorio in subCarpetas)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(subDirectorio));
                    nodoRaiz.Nodes.Add(node);

                    

                    TraerSubCarpetas(subDirectorio, node);
                    TraerArchivos(subDirectorio, node);
                }
            }
            catch (Exception eror)
            {
                MessageBox.Show(eror.Message);
            }

        } 

        private void TraerArchivos(string ruta, TreeNode nodoRaiz) 
        {

            string[] Archivos = Directory.GetFiles(ruta);

            foreach (string archivo in Archivos)
            {
                TreeNode nodoArchivo = new TreeNode(Path.GetFileName(archivo));
                nodoRaiz.Nodes.Add(nodoArchivo);


            }

        }
      
        private void CargarTreeview(string rutaCarpetaRaiz, string nombreCarpeta) 
        {
            treeView1.Nodes.Clear();

            if (Directory.Exists(rutaCarpetaRaiz))
            {
                TreeNode nodoRaiz = new TreeNode(nombreCarpeta);
                treeView1.Nodes.Add(nodoRaiz);

                TraerSubCarpetas(rutaCarpetaRaiz, nodoRaiz);

                TraerArchivos(rutaCarpetaRaiz, nodoRaiz);

            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"../../");

            string ruta=info.FullName;

            CargarTreeview(ruta,info.Name);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblContenido.Text = "";

            try
            {
                DirectoryInfo info = new DirectoryInfo(@"../..");

                string rutaArchivo = info.FullName + "//" + e.Node.Text;

                StreamReader lectorArchivos = new StreamReader(rutaArchivo);

                if (lectorArchivos != null)
                {
                    while (!lectorArchivos.EndOfStream)
                    {
                        lblContenido.Text += lectorArchivos.ReadLine();
                    }
                }

                lectorArchivos.Close();

            }
            catch(Exception) 
            {


            }    
        }
    }
}
