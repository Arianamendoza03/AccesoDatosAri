using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class AccederDatos : Form
    {
        public AccederDatos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int res = Clases.Personas.insertar(this.txtCedula.Text, this.txtApellido.Text, this.txtNombres.Text, Convert.ToDateTime(this.txtFechaNaci.Text),
                Convert.ToDouble(this.txtPeso.Text));


            // MessageBox.Show("Filas Insertadas: " + res.ToString());
            if (res > 0)
                MessageBox.Show("Registro agregado con exitos...");
            else
                MessageBox.Show("No se pudo insertar el registro...");
        }
    }
}
