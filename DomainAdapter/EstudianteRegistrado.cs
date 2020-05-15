using System;

namespace DomainAdapter
{
    public class EstudianteRegistrado : IEstudianteRegistrado
    {
        private String Nick { get; set; }

        public String getNick()
        {
            return Nick;
        }

        public void setNick(String nick)
        {
            this.Nick = nick;
        }
    }
}
