using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio10
{
    public class Catedratico : Persona
    {
        string tituloProfesional;
        string noColegiado;

        public string TituloProfesional { get => tituloProfesional; set => tituloProfesional = value; }
        public string NoColegiado { get => noColegiado; set => noColegiado = value; }
    }
}