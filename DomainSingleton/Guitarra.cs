using System;

namespace DomainSingleton
{
    public class Guitarra
    {
        private static Guitarra _guitarra;
        public string Tipo { get; set; }

        public Guitarra()
        {

        }

        public static Guitarra GetGuitarra()
        {
            if (_guitarra ==null)
            {
                _guitarra = new Guitarra();
            }

            return _guitarra;
        }

        public string GetTipo()
        {
            return Tipo;
        }
    }
}
