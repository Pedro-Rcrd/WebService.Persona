using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServices.Persona.BLL;
using WebServices.Persona.Model;

namespace WebServices.Persona
{
    /// <summary>
    /// Descripción breve de WsInformacionRol
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WsInformacionRol : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }



        [WebMethod]
        public ListaRol listadoRolPreCredit(string valor)
        {

            RolBll rolBll = new RolBll();
            DataTable dtRol = rolBll.obtenerListadoRol(valor);

            List<Rol> listaRol = new List<Rol>();

            for (int i = 0; i < dtRol.Rows.Count; i++)
            {
                Rol nuevoRol = new Rol();
                nuevoRol.CodigoRol = dtRol.Rows[i]["CodigoRol"].ToString();
                nuevoRol.NombreRol = dtRol.Rows[i]["NombreRol"].ToString();
                nuevoRol.DescripcionRol = dtRol.Rows[i]["DescripcionRol"].ToString();
                nuevoRol.Estatus = dtRol.Rows[i]["Estatus"].ToString();

                listaRol.Add(nuevoRol);

            }

            ListaRol respuestaRol = new ListaRol();
            respuestaRol.rol = listaRol;

            return respuestaRol;

        }

    }
}
