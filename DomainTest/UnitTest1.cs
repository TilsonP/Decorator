using Domain;
using NUnit.Framework;

namespace DomainTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FordFiestaStandar()
        {
            Vendible auto = new FordFiesta();

            Assert.AreEqual(auto.GetPrecio(), 1500);
        }

        [Test]
        public void FordFiestaConAire()
        {
            Vendible auto = new FordFiesta();
            auto = new AireAcondicionado(auto);
            auto = new ReproductorMp3(auto);

            Assert.AreEqual(auto.GetPrecio(), 1800);
        }

        [Test]
        public void FiatUnoFull()
        {
            Vendible auto = new FiatUno();
            auto = new AireAcondicionado(auto);
            auto = new ReproductorMp3(auto);
            
            Assert.AreEqual(auto.GetPrecio(), 1300);
        }
        
        
    }
}