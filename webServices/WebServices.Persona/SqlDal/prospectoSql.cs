using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace WebServices.Persona.SqlDal
{
    public class prospectoSql
    {
       //Método para ejecutar el procedimiento almacenado y traer toda la información que contiene.

        //Llamando la cadena de conexión
        private readonly string _sqlCons = ConfigurationManager.AppSettings["sqlCons"];

        //¿Cómo se quiere obtener los datos, tabla u otro formato?

        public DataTable obtenerListadoProspecto()
        {
            DataTable dtProspecto = new DataTable();
            string procedimiento = "spr_obtenerListaProspectoPreCredit";
            try
            {
                //Oteniendo los datos del procedimiento almacenado
                DataSet dsResultado = SqlHelper.ExecuteDataset(_sqlCons, CommandType.StoredProcedure, procedimiento, null);
                //Dataset es un vector de tablas, como el SP solo devuelve una tabla por ende el indece del vector es cero.
                dtProspecto = dsResultado.Tables[0];
            }
            catch
            {
                return null;

            }

            return dtProspecto;
        }

    }
}