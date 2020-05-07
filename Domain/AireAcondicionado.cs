namespace Domain
{
    public class AireAcondicionado : AutoDecorator
    {
        public AireAcondicionado(Vendible vendible) : base(vendible)
        {
        }

        public override string GetDescripcion()
        {
            return Vendible.GetDescripcion() + " con Aire acondicionado";
        }

        public override double GetPrecio()
        {
            return Vendible.GetPrecio() + 200;
        }
    }
}