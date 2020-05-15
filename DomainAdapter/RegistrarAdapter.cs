using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.Graph;

namespace DomainAdapter
{
    public class RegistrarAdapter : IEstudianteRegistrado
    {
        private IEstudiante Estudiante { get; }

        public RegistrarAdapter(IEstudiante estudiante)
        {
            this.Estudiante = estudiante;
        }

        public String getNick()
        {
            return Estudiante.getPrimerApellido() + Estudiante.getSegundoApellido() + Estudiante.getNombre();
        }

        public void setNick(String NickGenerado)
        {
            String[] nick = NickGenerado.Split();
            String primerApellido = nick[0];
            String segundoApellido = nick[1];
            String nombre = nick[2];
            Estudiante.setPrimerApellido(primerApellido);
            Estudiante.setSegundoApellido(segundoApellido);
            Estudiante.setNombre(nombre);
        }
    }
}
