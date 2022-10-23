using Cine.Datos;
using Cine.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class FrmPrincipal : Form
    {
        private FrmLogin login;
        private DBHelper oDatos;
        private int numImagen;
        public FrmPrincipal()
        {
            InitializeComponent();
            oDatos = new DBHelper();
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login=new FrmLogin();
            login.Show();
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmButacas frmButacas =new FrmButacas();
            frmButacas.Show();
        }

       

        private void CargarCboFunciones(DateTime fecha)
        {
            
            cboFunciones.DataSource = oDatos.ConsultarDB("PA_CONSULTAR_PELICULAS",fecha);
            cboFunciones.DisplayMember = "nom_pelicula";
            cboFunciones.ValueMember = "f.id_pelicula";
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

            CargarCboFunciones(dtpFecha.Value);



        }
        private void LimpiarCombo()
        {
            cboFunciones.Items.Clear();
        }

        private void Slider()
        {
            numImagen = (int)cboFunciones.SelectedValue;
            Sliderpicturebox.ImageLocation = String.Format(@"Images\{0}.jpg", numImagen);
            
        }

        private void cboFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slider();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FrmComprobante frm = new FrmComprobante();
            frm.Show();
        }
    }
}
