using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio10
{
    public class Administrativo : Persona
    {
        string profesion;
        string noIgss;

        public string Profesion { get => profesion; set => profesion = value; }
        public string NoIgss { get => noIgss; set => noIgss = value; }
    }
}