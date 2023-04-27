using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio10
{
    public class Alumno : Persona
    {
        string carnet;
        List<Curso> cursos;

        public string Carnet { get => carnet; set => carnet = value; }
        public List<Curso> Cursos { get => cursos; set => cursos = value; }

        public Alumno()
        {
            cursos = new List<Curso>();
        }
    }
}