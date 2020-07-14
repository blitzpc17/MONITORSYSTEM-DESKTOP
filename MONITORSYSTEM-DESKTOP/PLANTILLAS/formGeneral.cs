using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONITORSYSTEM_DESKTOP.PLANTILLAS
{
    public partial class formGeneral : Form
    {


        #region Variables
        #endregion


        #region Constructores
        public formGeneral()
        {
            InitializeComponent();
        }
        private void formGeneral_Load(object sender, EventArgs e)
        {
            InicializarDiseno();
        }
        #endregion

        #region Metodos en general
        #endregion

        #region Metodos de controles
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos de diseno
        private void InicializarDiseno()
        {
            SetColorBordersFrame();
        }
        private void SetColorBordersFrame()
        {
            pTop.BackColor = Color.FromArgb(240, 188, 94);
            pBot.BackColor = Color.FromArgb(240, 188, 94);
            pBotonera.BackColor = Color.FromArgb(238, 238, 238);
        }


        #endregion

        
    }
}
