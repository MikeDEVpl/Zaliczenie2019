using Microsoft.VisualStudio.TestTools.UnitTesting;
using WielkieKino.Dane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WielkieKino.Dane.Tests
{
    [TestClass()]
    public class MetodyPomocniczeTests
    {
        [TestMethod()]
        public void CzyMoznaKupicBiletTest()
        {
            MetodyPomocnicze mp = new MetodyPomocnicze();
            bool miejsceZajete = mp.CzyMoznaKupicBilet(Dane.SkladDanych.Bilety, Dane.SkladDanych.Seanse[0], 5, 5);
            Assert.IsFalse(miejsceZajete);
        }

        [TestMethod()]
        public void LiczbaWolnychMiejscWSaliTest()
        {
            MetodyPomocnicze mp = new MetodyPomocnicze();
            int wynik = mp.LiczbaWolnychMiejscWSali(Dane.SkladDanych.Bilety, Dane.SkladDanych.Seanse[0]);
            Assert.AreEqual(wynik, 72);
        }

        [TestMethod()]
        public void CalkowitePrzychodyZBiletowTest()
        {
            MetodyPomocnicze mp = new MetodyPomocnicze();
            double wynik = mp.CalkowitePrzychodyZBiletow(Dane.SkladDanych.Bilety);
            Assert.AreEqual(wynik, 400.00);
        }

        [TestMethod()]
        public void CzyMoznaDodacSeansTest()
        {
            MetodyPomocnicze mp = new MetodyPomocnicze();
            bool czyMoznaDodac = mp.CzyMoznaDodacSeans(Dane.SkladDanych.Seanse, Dane.SkladDanych.Sale[0], Dane.SkladDanych.Filmy[0], new DateTime(2019, 1, 20, 12, 00, 00));
            Assert.IsFalse(czyMoznaDodac);
        }
    }
}