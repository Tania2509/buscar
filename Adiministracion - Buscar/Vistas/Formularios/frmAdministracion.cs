using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmAdministracion : Form
    {
        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = Modelos.Entidades.Producto.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarPeliculas()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Modelos.Entidades.Producto.CargarProductos();
        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            MostrarPeliculas();
        }
    }
}
