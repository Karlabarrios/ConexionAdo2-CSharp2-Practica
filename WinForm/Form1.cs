using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frmPrincipal : Form
    {
        private List<Disco> listaDiscos { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DiscosService servicio = new DiscosService();
            listaDiscos = servicio.listar();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
            CargarImagen(listaDiscos[0].UrlImagen);
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagen);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pxbDiscos.Load(imagen);
            }
            catch (Exception)
            {
                pxbDiscos.Load("https://atrilco.com/wp-content/uploads/2017/11/ef3-placeholder-image.jpg");
            }
        }

        private void lblApp_MouseMove(object sender, MouseEventArgs e)
        {
            lblApp.ForeColor = Color.Yellow;
            lblApp.Cursor = Cursors.Hand;
        }

        private void lblApp_MouseLeave(object sender, EventArgs e)
        {
            lblApp.ForeColor = Color.Ivory;
            lblApp.Cursor = Cursors.Arrow;
        }
    }
}
