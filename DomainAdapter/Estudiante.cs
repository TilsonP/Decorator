using System;
using System.Collections.Generic;
using System.Text;

namespace DomainAdapter
{
    class Estudiante : IEstudiante
    {
        private String Nombre { get; set; }
        private String PrimerApellido { get; set; }
        private String SegundoApellido { get; set; }

        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public String getPrimerApellido()
        {
            return PrimerApellido;
        }

        public void setPrimerApellido(String primerApellido)
        {
            this.PrimerApellido = primerApellido;
        }

        public String getSegundoApellido()
        {
            return SegundoApellido;
        }

        public void setSegundoApellido(String segundoApellido)
        {
            this.SegundoApellido = segundoApellido;
        }
    }
}
