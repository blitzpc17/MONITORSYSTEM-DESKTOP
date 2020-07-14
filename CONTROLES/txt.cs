using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLES
{
    public class txt : TextBox
    {
        private string textoVacio;
        [Category("Texto Vacio")]
        public string TextoVacio
        {
            get { return textoVacio; }
            set { textoVacio = value; }
        }

        private Color colorTextoVacio;
        public Color ColorTextoVacio
        {
            get { return colorTextoVacio; }
            set { colorTextoVacio = value; }
        }

        bool bndTextoVacio = false;

        public txt()
        {
            colorTextoVacio = Color.Gray;
            textoVacio = "<Placeholder>";
        }

        private void VerificaTextoVacio()
        {
            if (this.Text.Length > 0)
                bndTextoVacio = false;
            else
                bndTextoVacio = true;

            this.SetStyle(ControlStyles.UserPaint, bndTextoVacio);
            this.Refresh();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            VerificaTextoVacio();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            VerificaTextoVacio();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (bndTextoVacio)
                e.Graphics.DrawString(textoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(colorTextoVacio), new Point(0, 0));

            else
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
            base.OnPaint(e);
        }
    }
}
