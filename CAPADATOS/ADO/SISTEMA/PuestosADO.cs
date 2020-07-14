using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES.DBO;
using CONEXION;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CAPADATOS.ADO.SISTEMA
{
    public class PuestosADO:Conexion
    {
        #region Variables
        private static IDbConnection Db;
        #endregion

        #region Constructores
        public PuestosADO()
        {
            Db = new SqlConnection(CadenaSql());
        }
        #endregion

        #region Metodos en general

        public void Listar()
        {
            string query = "SELECT *FROM PUESTOS";
            var x = Db.Query<PUESTOS>(query);
        }
        public void Insertar()
        {
            string sql = "INSERT INTO PUESTOS (NOMBRE) Values (@NOMBRE);";
            var affectedRows = Db.Execute(sql, new { NOMBRE = "VENDEDOR" });
            Console.WriteLine(affectedRows);

        }
        public void Modificar()
        {

        }
        public void Eliminar()
        {

        }
        #endregion


    }
}
