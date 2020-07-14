using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.DBO
{
    public class USUARIOS
    {
        public int ID { get; set; }
        public string CLAVE { get; set; }
        public string CONTRASENA { get; set; }
        public int PERFILESID { get; set; }
        public int EMPLEADOSID { get; set; }
        public DateTime CREATED_AT { get; set; }
        public DateTime UPDATED_AT { get; set; }
        public bool ACTIVO { get; set; }
    }
}
