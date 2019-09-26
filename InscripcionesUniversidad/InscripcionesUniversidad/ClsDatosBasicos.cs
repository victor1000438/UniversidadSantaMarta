using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionesUniversidad
{
    class ClsDatosBasicos
    {

        private string Nombre;
        private string Apellidos;
        private string Documento;
        private int Edad;
        private string Correo;
        private string Telefono;
        private string FechaE;
        

        public ClsDatosBasicos()
        {
            Nombre1 = "";
            Apellidos1 = "";
            Documento1 = "";
            Edad1 = 0;
            Correo1 = "";
            Telefono1 = "";
            FechaE1 = "";
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Documento1 { get => Documento; set => Documento = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string FechaE1 { get => FechaE; set => FechaE = value; }
    }
}
