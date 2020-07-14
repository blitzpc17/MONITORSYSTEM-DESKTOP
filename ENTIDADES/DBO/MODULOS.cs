using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.DBO
{
    public class MODULOS
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string RUTA { get; set; }
        public DateTime CREATED_AT { get; set; }
        public DateTime UPDATED_AT { get; set; }
        public bool ACTIVO { get; set; }
        public int MENUCATEGORIASID { get; set; }
        public int MODULOPADREID { get; set; }
    }
}
