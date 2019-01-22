using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace FahrzeugparkUnitTest
{
    //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgeführt werden sie
    ///über den Test-Explorer
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_über_Max_Geschwindigkeit()
        {
            PKW pkw = new PKW("VW", 280, 31000, 5);

            pkw.StarteMotor();

            pkw.Beschleunige(300);

            //Dies ASSERT-Klasse enthält diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden können. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Beschleunige_PKW_über_Max_Geschwindigkeitt()
        {
            PKW pkw = new PKW("VW", 280, 31000, 5);

            pkw.StarteMotor();

            pkw.Beschleunige(300);

            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }
    }
}
