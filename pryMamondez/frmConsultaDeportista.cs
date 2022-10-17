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

namespace pryMamondez
{
    public partial class frmConsultaDeportista : Form
    {

        //DECLARANDO LAS VARIABLES Y OBJETOS GLOBALES DEL PRY
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;

        public string varRutaDeBaseDeDatos =
            "C:\\Users\\Romancito\\Desktop\\Facu\\pryMamondez\bin\\Debug\\DEPORTE.accdb";
        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {
            try
            {
                conexionBase = new OleDbConnection(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    varRutaDeBaseDeDatos);

                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();

                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.TableDirect;
                queQuieroDeLaBase.CommandText = "DEPORTISTA";

                lectorDeConsultas = queQuieroDeLaBase.ExecuteReader();

                lblDatos.Text = "";

                while (lectorDeConsultas.Read())
                {
                    lblDatos.Text += lectorDeConsultas["Nombre"].ToString() + "\n";
                }

                lectorDeConsultas.Close();
                conexionBase.Close();

                //REDUCIR LA RUTA EL ARCHIVO, QUE INDIQUE A LA CARPETA DEL PROYECTO
                //VINCULAR LA GRILLA CON LOS DATOS

            }
            catch (Exception mensajito)
            {
                lblDatos.Text = mensajito.Message;

            }
        }
    }
}
