using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS.ADO.SISTEMA;
using ENTIDADES.DBO;

namespace CAPALOGICA.LOGICAS.SISTEMA
{
    public class PuestosLogica
    {
        #region Variables
        private PuestosADO contexto;
        #endregion

        #region Constructores
        public PuestosLogica()
        {
            contexto = new PuestosADO();
        }
        #endregion

        #region Metodos generales
        public void Insertar()
        {
            contexto.Insertar();
        }
        #endregion


    }
}
