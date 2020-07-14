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
    public partial class catForm : Form
    {
        #region Variables
        #endregion

        #region Constructores
        public catForm()
        {
            InitializeComponent();
        }
        private void catForm_Load(object sender, EventArgs e)
        {
            InicializarDiseno();
        }
        #endregion

        #region Metodos generales
        #endregion

        #region Metodos de controles
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
