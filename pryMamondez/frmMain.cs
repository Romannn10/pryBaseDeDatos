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
    public partial class frmMain : Form
    {
        //DECLARANDO LAS VARIABLES Y OBJETOS GLOBALES DEL PRY
        public OleDbConnection conexionBase;
        public OleDbCommand queQuieroDeLaBase;
        public OleDbDataReader lectorDeConsultas;

        public string varRutaDeBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            "\\DEPORTE.accdb";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblFechaActual.Text = DateTime.Now.ToString();

                conexionBase = new OleDbConnection("\\DEPORTE.accdb" + varRutaDeBaseDeDatos);

                conexionBase.Open();

                lblEstado.Text = "Conectado: " + conexionBase.ConnectionString;
                //lblEstado.ForeColor = Color.Green;
                statusStrip1.BackColor = Color.GreenYellow;
            }
            catch (Exception mensajito)
            {
                lblEstado.Text = mensajito.Message;
                //lblEstado.ForeColor = Color.Red;
                statusStrip1.BackColor = Color.Red;
                //throw;
            }
        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista frmConsultaDeportista = new frmConsultaDeportista();
            frmConsultaDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador frmConsultaEntrenador = new frmConsultaEntrenador();
            frmConsultaEntrenador.ShowDialog();
        }
    }
}
