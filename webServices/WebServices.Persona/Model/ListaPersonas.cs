using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServices.Persona.Model
{
    [XmlRoot("LISTA_PERSONA")]
    public class ListaPersonas
    {
        //Vector ObjPersona para que pueda almacenar mas de una persona.
        [XmlElement("Persona")]
        //public ObjPersona[] personaObj { get; set; }

        public List<Personas> persona { get; set; }
    }
}