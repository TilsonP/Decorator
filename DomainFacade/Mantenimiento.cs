using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFacade
{
    public class Mantenimiento
    {
        private CalibrarPuente calibrarPuente;
        private CambiarDiapason cambiarDiapason;
        private PonerCuerdas ponerCuerdas;

        public Mantenimiento()
        {
            calibrarPuente = new CalibrarPuente();
            cambiarDiapason = new CambiarDiapason();
            ponerCuerdas = new PonerCuerdas();
        }

        public int MantenimientoGuitarraAcustica(GuitarraAcustica guitarra)
        {
            return 1;
        }

        public int MantenimientoGuitarraElectrica(GuitarraElectrica guitarra)
        {
            return 2;
        }

        public int MantenimientoGuitarraElectrocustica(GuitarraElectroacustica guitarra)
        {
            return 3;
        }

        public void Trabajar(Guitarra guitarra)
        {
            switch (guitarra)
            {
                case GuitarraAcustica guitarraAcustica:
                    MantenimientoGuitarraAcustica(guitarraAcustica);
                    break;
                case GuitarraElectrica guitarraElectrica:
                    MantenimientoGuitarraElectrica(guitarraElectrica);
                    break;
                case GuitarraElectroacustica guitarraElectroacustica:
                    MantenimientoGuitarraElectrocustica(guitarraElectroacustica);
                    break;
            }
        }
    }
}
