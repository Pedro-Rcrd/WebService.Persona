using System;
using System.Collections.Generic;
using System.Data;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServices.Persona.BLL;
using WebServices.Persona.Model;

namespace WebServices.Persona
{
    /// <summary>
    /// Descripción breve de wsConsultaBuro
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsConsultaBuro : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        //METODO DEL IGGS
        public double CalculaIggs(double salario)
        {
            double porcentajeIggs = 4.833;
            double resultado = salario / porcentajeIggs;
            return resultado;

        }
        [WebMethod]
        public string InformacionPersonaString()
        {
            return "<PERSONA><CODIGO_PERSONA>24123363</CODIGO_PERSONA><NOMBRE>ORTIZ CRUZ, KARLA GABRIELA</NOMBRE><SEXO>F</SEXO><FECHA_NACIMIENTO>01/01/1998</FECHA_NACIMIENTO><EDAD>24</EDAD><ORDEN>DPI</ORDEN><REGISTRO>3618444840101</REGISTRO><ACODIGO_MUNICIPIO>GUA</ACODIGO_MUNICIPIO><ACODIGO_PAIS>GTM</ACODIGO_PAIS></PERSONA>";
        }

        [WebMethod]
        public string InformacionPersonaObjeto(Personas persona)
        {
            return "<PERSONA><CODIGO_PERSONA>24123363</CODIGO_PERSONA><NOMBRE>ORTIZ CRUZ, KARLA GABRIELA</NOMBRE><SEXO>F</SEXO><FECHA_NACIMIENTO>01/01/1998</FECHA_NACIMIENTO><EDAD>24</EDAD><ORDEN>DPI</ORDEN><REGISTRO>3618444840101</REGISTRO><ACODIGO_MUNICIPIO>GUA</ACODIGO_MUNICIPIO><ACODIGO_PAIS>GTM</ACODIGO_PAIS></PERSONA>";
        }

        [WebMethod]
        //SI NO SE COLOCA OBJECTO en el nombre del metodo no funciona.
        public Personas InformacionPersonaObjecto()
        {
            //INSTANCIANDO OBJETO
            Personas nuevaPersona = new Personas();
            nuevaPersona.PrimerNombre = "Pedro";
            nuevaPersona.SegundoNombre = "Ricardo";
            nuevaPersona.PrimerApellido = "Lopez";
            nuevaPersona.SegundoApellido = "Sapalu";
            nuevaPersona.FechaNacimiento = DateTime.Now.ToString("dd/MM/yyyy");


            return nuevaPersona;
        }

        [WebMethod(EnableSession = true)]
        public ListaPersonas listadoPersonas()
        {
            ListaPersonas respuestaPersonas = new ListaPersonas();
            Personas[] listaPersonas = new Personas[2];
            
            Personas persona1 = new Personas();
            persona1.PrimerNombre = "Pedro";
            persona1.SegundoNombre = "Ricardo";
            persona1.PrimerApellido = "Lopez";
            persona1.SegundoApellido = "Sapalu";
            persona1.FechaNacimiento = DateTime.Now.ToString("dd/MM/yyyy");

            Personas persona2 = new Personas();
            persona2.PrimerNombre = "Lopez";
            persona2.SegundoNombre = "Sapalu";
            persona2.PrimerApellido = "Pedro";
            persona2.SegundoApellido = "Ricardo";
            persona2.FechaNacimiento = DateTime.Now.ToString("dd/MM/yyyy");

            listaPersonas[0] = persona1;
            listaPersonas[1] = persona2;
            
            //Aquí se cambio el tipo de datos de objeto persona, ya no es vector sino lista,
            //Por eso el error que se presenta al descomentarlo.
            //respuestaPersonas.persona = listaPersonas;
            return respuestaPersonas;
        }


        [WebMethod]
        public ListaPersonas ListadoPersonasPrecredit()
        {

            //Llamar a la parte del negocio, creando un objeto.
            prospectoBll prospectoBll = new prospectoBll();

            //Crear variable de tipo tabla
            DataTable dtProspecto = prospectoBll.obtenerListadoProspecto();

            ListaPersonas respuestaPersona = new ListaPersonas();
            List<Personas> listapersonas = new List<Personas>(); 


            for (int i = 0; i < dtProspecto.Rows.Count; i++)
            {
                Personas nuevaPersona = new Personas();
                nuevaPersona.PrimerNombre = dtProspecto.Rows[i]["primerNombre"].ToString();
                nuevaPersona.SegundoNombre = dtProspecto.Rows[i]["segundoNombre"].ToString();
                nuevaPersona.PrimerApellido = dtProspecto.Rows[i]["primerApellido"].ToString();
                nuevaPersona.SegundoApellido = dtProspecto.Rows[i]["segundoApellido"].ToString();
                nuevaPersona.Nit = dtProspecto.Rows[i]["Nit"].ToString();
                nuevaPersona.Cui = dtProspecto.Rows[i]["Cui"].ToString();
                listapersonas.Add(nuevaPersona);

            }

            ListaPersonas respuestaPersonas = new ListaPersonas();
            respuestaPersonas.persona = listapersonas;
            return respuestaPersonas;

        }


    }
}
