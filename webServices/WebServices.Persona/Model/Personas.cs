using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServices.Persona.Model
{
    [XmlRoot(ElementName ="PROSPECTO")]
    public class Personas
    {
        [XmlElement(ElementName = "PRIMER_NOMBRE")]
        public string PrimerNombre { get; set; }

        [XmlElement(ElementName = "SEGUNDO_NOMBRE")]
        public string SegundoNombre { get; set; }

        [XmlElement(ElementName = "PRIMER_APELLIDO")]
        public string PrimerApellido { get; set; }

        [XmlElement(ElementName = "SEGUNDO_APELLIDO")]
        public string SegundoApellido { get; set; }

        [XmlElement(ElementName = "NIT")]

        public string Nit { get; set; }

        [XmlElement(ElementName = "CUI")]
        public string Cui { get; set; }

        [XmlElement(ElementName = "FECHA_NACIMIENTO")]
        public string FechaNacimiento { get; set; }


    }
}