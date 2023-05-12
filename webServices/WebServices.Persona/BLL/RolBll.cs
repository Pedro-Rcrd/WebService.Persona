using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebServices.Persona.SqlDal;

namespace WebServices.Persona.BLL
{
    public class RolBll
    {
        private RolSql _rolSql;
        public DataTable obtenerListadoRol(string valor)
        {
            _rolSql = new RolSql();

            return _rolSql.obtenerListadoRol(valor);

        }
    }
}