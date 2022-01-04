using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public partial class fmrGetPersonas : Form
    {
        public fmrGetPersonas()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            this.dgpersonas.DataSource = this.getpersona();
        }
        private void cargarpersonas()
        {
            this.dgpersonas.DataSource = this.getpersona();
        }


        private DataTable getpersona(string cedula = "")
        {
            string sql = "";
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-D1QBCII\SQLEXPRESS; database=TI2021; Integrated Security=true");
            if (cedula == "")
            {
                sql = "select cedula as Cédula, upper(apellidos+ ' ' + nombres) as [Nombre Completo], fechaNacimiento as [fecha de Nac.], Peso ";
                sql += "from Personas order by apellidos, nombres";
            }
            else
            {
                sql = "select cedula, apellidos, nombres, upper(apellidos+ ' ' + nombres) as nombreCompleto, fechaNacimiento, peso ";
                sql += "from Personas  order by apellidos, nombres";
            }

            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataAdapter ad1 = new SqlDataAdapter(comando);

            //pasar los datos del adaptador a un datatable
            DataTable dt = new DataTable();
            ad1.Fill(dt);

            return dt;
        }

        private void dgpersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if (this.dgpersonas.Columns[e.ColumnIndex].Name == "linkSeleccionar")
                {
                    //MessageBox.Show("CLICK en seleccionar !:D!");
                    String cedula = this.dgpersonas["Cédula", e.RowIndex].Value.ToString();
                    frmConxPersona frm1 = new frmConxPersona(cedula);
                    frm1.ShowDialog();
                }
                else if (this.dgpersonas.Columns[e.ColumnIndex].Name == "linkEliminar")
                {
                    // MessageBox.Show("CLICK en Eliminar!!!");
                    String cedula = this.dgpersonas["Cédula", e.RowIndex].Value.ToString();
                    //MessageBox.Show("la cedula es:" + cedula);

                    DialogResult dialog = MessageBox.Show("¿Estás seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.No)
                        return; //abandonar

                    int respuesta = Clases.Personas.borrar(cedula);
                    if (respuesta > 0)
                    {
                        this.cargarpersonas();
                        MessageBox.Show("registro borrado con exito  :D...");
                    }
                    else
                        MessageBox.Show("No se pudo borrar el archivo :d...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
