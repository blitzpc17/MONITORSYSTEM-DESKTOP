using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.DBO
{
    public class EMPLEADOS
    {
        public int ID { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string TELEFONO { get; set; }
        public string CORREO { get; set; }
        public string DIRECCION { get; set; }
        public string CP { get; set; }
        public string LOCALIDAD { get; set; }
        public int LOCALIDADID { get; set; }
        public DateTime CREATED_AT { get; set; }
        public DateTime UPDATED_AT { get; set; }
    }
}
