using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.DBO
{
    public class PERFILESPERMISOS
    {
        public int ID { get; set; }
        public int PERFILESID { get; set; }
        public int MODULOSID { get; set; }
        public DateTime CREATED_AT { get; set; }
        public DateTime UPDATED_AT { get; set; }
        public int USUARIOSOTORGOID { get; set; }
        public string MOTIVO { get; set; }
    }
}
