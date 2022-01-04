using System;
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
    public partial class frmConxPersona : Form
    {
        private string mCedula;
        public frmConxPersona(string cedula)
        {
            InitializeComponent();
            this.mCedula = cedula;
        }

        private void frmConxPersona_Load(object sender, EventArgs e)
        {
            MessageBox.Show("La cedula es: " + mCedula);
        }
    }
}
