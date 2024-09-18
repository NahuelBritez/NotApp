using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class frmTareas : Form
    {
        List<Tarea> listatareas = new List<Tarea>(); 
        public frmTareas()
        {
            InitializeComponent();
        }

        private void frmTareas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            TareasNegocio negocio = new TareasNegocio();
            listatareas = negocio.Listar();
            dgvTareas.DataSource = listatareas;
            
        }
    }
}
