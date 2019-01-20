using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WielkieKino.Lib;


namespace WielkieKino.App
{
    public class Program
    {
        /// <summary>
        /// Na podstawie danych seansu i sprzedanych biletów należy wyświetlić "podgląd"
        /// sali w ten sposób, że: każdy rząd to jedna linia tekstu, znaków w linii
        /// ma być tyle ile miejsc w rzędzie, miejsca zajęte są inaczej oznaczone niż
        /// miejsca wolne.
        /// </summary>
        /// <param name="sprzedaneBilety"></param>
        /// <param name="seans"></param>
        private static void WyswietlPodgladSali(List<Bilet> sprzedaneBilety, Seans seans)
        {
            int liczbaRzedow = seans.Sala.LiczbaRzedow;
            int liczbaMiejsc = seans.Sala.LiczbaMiejscWRzedzie;

            string[,] tab = new string[liczbaRzedow,liczbaMiejsc];

            for (int i = 0; i < liczbaRzedow; i++)
            {
                for (int j = 0; j < liczbaMiejsc; j++)
                {
                    tab[i,j] = "-";
                }
            }

            foreach (Bilet bilet in sprzedaneBilety)
            {
                if (bilet.Seans == seans)
                    tab[bilet.Rzad-1, bilet.Miejsce-1] = "O";
            }
                       
            for (int i = 0; i < liczbaRzedow; i++)
            {
                for (int j = 0; j < liczbaMiejsc; j++)
                {
                    Console.Write(tab[i,j]);
                }
                Console.WriteLine();
            }


        }

        /// <summary>
        /// Wyświetlony powinien być tytuł filmu, godzina rozpoczęcia, czas trwania
        /// i nazwa sali.
        /// </summary>
        /// <param name="seanse"></param>
        /// <param name="data"></param>
        private static void WyswietlFilmyOGodzinie(List<Seans> seanse, DateTime data)
        {
            //Wskazówka: Do obliczenia czy parametr data "wpada" w film można wykorzystać
            //metodę AddMinutes wykonanej na czasie rozpoczęcia seansu.


            foreach (var seans in seanse)
	        {
                DateTime czasRozpoczecia = seans.Date;
                DateTime czasZakonczenia = czasRozpoczecia.AddMinutes(seans.Film.CzasTrwania);

                if (data > czasRozpoczecia && data < czasZakonczenia)
        	    {
                    Console.WriteLine(seans.Film.Tytul + " " + seans.Date.Hour + " " + seans.Sala.Nazwa);
                }        	
            }


        }

        public static void Main(string[] args)
        {
            WyswietlPodgladSali(Dane.SkladDanych.Bilety, Dane.SkladDanych.Seanse[0]);
            /* Przykładowo:
            ----------
            ----------
            ----------
            ----------
            ----ooo---
            ----ooo---
            -----oo---
            ----------
            */
            KinoContext db = new KinoContext();
            Sala sala = new Sala()
            {
                Nazwa = "xxx",
                LiczbaMiejscWRzedzie = 4,
                LiczbaRzedow = 2
            };
            Film film = new Film()
            {
                Tytul = "zzz",
                CzasTrwania = 30,
                Gatunek = "Anime"
            };
            Seans seans = new Seans()
             {
                 Date = new DateTime(2019, 1, 20, 22, 00, 00),
                 Film = film,
                 Sala = sala
             };

            
            sala.Seanse.Add(seans);
            Bilet bilet = new Bilet(seans, 10.00, 1, 1);
            seans.Bilety.Add(bilet);
            film.Seanse.Add(seans);

            db.Filmy.Add(film);
            db.Seanse.Add(seans);
            db.Sale.Add(sala);
            db.SaveChanges();
        }
    }
}
