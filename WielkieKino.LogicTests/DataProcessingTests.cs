using Microsoft.VisualStudio.TestTools.UnitTesting;
using WielkieKino.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WielkieKino.Lib;

namespace WielkieKino.Logic.Tests
{
    [TestClass()]
    public class DataProcessingTests
    {
        [TestMethod()]
        public void WybierzFilmyZGatunkuTest()
        {
            DataProcessing dp = new DataProcessing();
            List<string> lista = dp.WybierzFilmyZGatunku(Dane.SkladDanych.Filmy, "Fantasy");
            Assert.AreEqual(lista[0], "Konan Destylator");
        }

        [TestMethod()]
        public void PodajCalkowiteWplywyZBiletowTest()
        {
            DataProcessing dp = new DataProcessing();
            int wplywy = dp.PodajCalkowiteWplywyZBiletow(Dane.SkladDanych.Bilety);
            Assert.AreEqual(wplywy, 400);
        }

        [TestMethod()]
        public void WybierzFilmyPokazywaneDanegoDniaTest()
        {
            DataProcessing dp = new DataProcessing();
            List<Film> pokazywane = dp.WybierzFilmyPokazywaneDanegoDnia(Dane.SkladDanych.Seanse, new DateTime(2019, 1, 20, 12, 00, 00));
            Assert.AreEqual(pokazywane[0].Tytul, "Konan Destylator");
        }

        [TestMethod()]
        public void ZwrocFilmNaKtorySprzedanoNajwiecejBiletowTest()
        {
            DataProcessing dp = new DataProcessing();
            Film film = dp.ZwrocFilmNaKtorySprzedanoNajwiecejBiletow(Dane.SkladDanych.Filmy, Dane.SkladDanych.Bilety);
            Assert.AreEqual(film.Tytul, "Konan Destylator");
        }

        [TestMethod()]
        public void NajpopularniejszyGatunekTest()
        {
            DataProcessing dp = new DataProcessing();
            string gatunek = dp.NajpopularniejszyGatunek(Dane.SkladDanych.Filmy);
            Assert.AreEqual(gatunek, "Obyczajowy");
        }

        [TestMethod()]
        public void ZwrocSaleGdzieJestNajwiecejSeansowTest()
        {
            DataProcessing dp = new DataProcessing();
            Sala sala = dp.ZwrocSaleGdzieJestNajwiecejSeansow(Dane.SkladDanych.Seanse, new DateTime(2019, 01, 20));
            Assert.AreEqual(sala.Nazwa, "Wisła");
        }
    }
}