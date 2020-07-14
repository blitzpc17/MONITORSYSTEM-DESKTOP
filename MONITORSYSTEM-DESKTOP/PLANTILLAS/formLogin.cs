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
    public partial class formLogin : Form
    {


        #region Variables
        #endregion

        #region Constructores
        public formLogin()
        {
            InitializeComponent();
        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            InicializarDiseno();
        }

        #endregion


        #region Metodos generales
        #endregion


        #region Metodos de controles
        #endregion


        #region Metodos de diseño
        private void InicializarDiseno()
        {
            SetColorBordersFrame();
            EnableMaxMinButtons();
            MsjErrorLbl();
        }

        private void SetColorBordersFrame()
        {
            pTop.BackColor = Color.FromArgb(240, 188, 94);
            pBot.BackColor = Color.FromArgb(240, 188, 94);
        }
        private void MsjErrorLbl(int edo = 0, string msj = null)
        {
            switch (edo)
            {
                case 0:
                    lblUsuario.Text = null;
                    lblPassword.Text = null;
                    break;
                case 1:
                    lblUsuario.Text = msj;
                    break;
                case 2:
                    lblPassword.Text = null;
                    break;
            }
        }
        private void EnableMaxMinButtons()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        #endregion

       
    }
}
