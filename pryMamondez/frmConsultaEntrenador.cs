using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMamondez
{
    public partial class frmConsultaEntrenador : Form
    {
        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void frmConsultaEntrenador_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception mensajito)
            {
                lblDatos.Text = mensajito.Message;
                //throw;
            }
        }
    }
}
