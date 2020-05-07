namespace Domain
{
    public class ReproductorMp3 : AutoDecorator
    {
        public ReproductorMp3(Vendible vendible) : base(vendible)
        {
        }
        
        public override string GetDescripcion()
        {
            return Vendible.GetDescripcion() + " con reproductor Mp3";
        }

        public override double GetPrecio()
        {
            return Vendible.GetPrecio() + 100;
        }
    }
}