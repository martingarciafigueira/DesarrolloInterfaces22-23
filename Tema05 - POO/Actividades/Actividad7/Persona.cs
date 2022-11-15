using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad7
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;
        private string estadoCivil = "SOLTERO";

        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.edad = 0;
            this.dni = "";
            this.estadoCivil = "";
        }

        public Persona(string nombre, string apellidos, int edad, string dni, string estadoCivil)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.dni = dni;
            this.estadoCivil = estadoCivil;
        }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.dni = dni;
            this.estadoCivil = "SOLTERO";
        }

        ~Persona()
        {
            Console.WriteLine("Se ha borrado un objeto");
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellidos { get => this.apellidos; set => this.apellidos = value; }
        public int Edad { get => this.edad; set => this.edad = value; }
        public string Dni { get => this.dni; set => this.dni = value; }
        public string EstadoCivil { get => this.estadoCivil; set => this.estadoCivil = value; }

        public bool EsJubilado()
        {
            if (this.edad >= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void describirPersona()
        {
            Console.WriteLine(this.nombre + " " + this.apellidos + " " + this.edad + " " + this.dni + " " + this.estadoCivil);
        }
    }
}
