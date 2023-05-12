using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServices.Persona.Model
{
    public class Rol
    {
        [XmlElement(ElementName = "CODIGO_ROL")]
        public string CodigoRol { get; set; }

        [XmlElement(ElementName = "NOMBRE_ROL")]
        public string NombreRol { get; set; }


        [XmlElement(ElementName = "DESCRIPCION_ROL")]
        public string DescripcionRol { get; set; }


        [XmlElement(ElementName = "ESTATUS")]
        public string Estatus { get; set; }
    }
}