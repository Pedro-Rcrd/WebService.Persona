using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebServices.Persona.SqlDal
{
    public class RolSql
    {

        //Llamando la cadena de conexión
        private readonly string _sqlCons = ConfigurationManager.AppSettings["sqlCons"];

        //Método que trae la información del procedimiento almacenado.
        public DataTable obtenerListadoRol(string valor)
        {
            DataTable dtRol = new DataTable();
            string procedimientoRol = "spr_obtenerListaRolPreCreditPorEstatus";
            try
            {
                //Configurando parámetro

                SqlParameter[] parametroEstatus = SqlHelperParameterCache.GetSpParameterSet(_sqlCons, procedimientoRol);
                parametroEstatus[0].Value = valor;



                //Oteniendo los datos del procedimiento almacenado
                DataSet dsResultado = SqlHelper.ExecuteDataset(_sqlCons, CommandType.StoredProcedure, procedimientoRol, parametroEstatus[0]);
                //Dataset es un vector de tablas, como el SP solo devuelve una tabla por ende el indece del vector es cero.
                //Se extrae esa tabla en el dataset
                dtRol = dsResultado.Tables[0];
            }
            catch
            {
                return null;

            }

            return dtRol;
        }
    }
}