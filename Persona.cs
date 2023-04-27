using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio10
{
    public class Persona
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public int calcularEdad()
        {
            TimeSpan intervalo = DateTime.Now - fechaNacimiento;
            int edad = Convert.ToInt32(Math.Floor(intervalo.TotalDays / 365));
            return edad;
        }
    }
}