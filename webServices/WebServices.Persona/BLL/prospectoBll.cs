using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using WebServices.Persona.SqlDal;

namespace WebServices.Persona.BLL
{


    
    public class prospectoBll
    {
        //LLAMANDO LA CLASE prospecoSql de la carpeta SqlDal
        //private prospectoSql _prospectoSql;
        //Directo
        private prospectoSql _prospectoSql = new prospectoSql(); //Crea tipo objeto sql




        //Aquí se debe llamar a clase de Datos

        //Se debe crear un método con el mismo nombre del metodo de la clase prospectoSql
        public DataTable obtenerListadoProspecto()
        {
            //_prospectoSql = new prospectoSql();

            return _prospectoSql.obtenerListadoProspecto();
            //Aqui se obtiene lo que se obtiene del mismo método pero de  la clase prospectoSql de la carpeta SqlDal
            

        }


    }
}