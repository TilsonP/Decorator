using System;
using System.Collections.Generic;

namespace DomainComposite
{
    public class Computador : IComponentes
    {
        List<IComponentes> componentes;

        public Computador()
        {
            componentes = new List<IComponentes>();
        }

        public void Agregar(IComponentes componente)
        {
            componentes.Add(componente);
        }

        public string Operacion()
        {
            return "Componente Agregado";
        }
    }
}
