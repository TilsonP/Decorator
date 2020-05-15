using System;
using System.Collections.Generic;
using System.Text;

namespace DomainAdapter
{
    public interface IEstudiante
    {
        String getNombre();
        void setNombre(String nombre);
        String getPrimerApellido();
        void setPrimerApellido(String primerApellido);
        String getSegundoApellido();
        void setSegundoApellido(String segundoApellido);
    }
}
