namespace Domain
{
    public abstract class AutoDecorator : Vendible
    {
        protected Vendible Vendible { get; set; }

        protected AutoDecorator(Vendible vendible)
        {
            Vendible = vendible;
        }

        public abstract string GetDescripcion();

        public abstract double GetPrecio();
    }
}