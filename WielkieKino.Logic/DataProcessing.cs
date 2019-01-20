﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WielkieKino.Lib;

namespace WielkieKino.Logic
{
    /// <summary>
    /// Metody do napisania z wykorzystaniem LINQ (w składni zapytania, wyrażeń
    /// lambda lub mieszanej)
    /// </summary>
    public class DataProcessing
    {
        public List<string> WybierzFilmyZGatunku(List<Film> filmy, string gatunek)
        {
            List<Film> films = (from Film film in filmy 
                                  where film.Gatunek == gatunek
                                  select film).Distinct().ToList();
            // Właściwa odpowiedź: np. "Konan Destylator" dla "Fantasy"
            List<string> fil = new List<string>();
            foreach (var film in films)
	        {
                fil.Add(film.Tytul);
        	}
            return fil;
        }

        /// <summary>
        /// Sumujemy wpływy bez względu na datę seansu
        /// </summary>
        /// <param name="bilety"></param>
        /// <returns></returns>
        public int PodajCalkowiteWplywyZBiletow(List<Bilet> bilety)
        {
            double suma = (from Bilet bilet in bilety
                        select bilet.Cena).Sum();
            // Właściwa odpowiedź: 400
            return (int)suma;
        }

        public List<Film> WybierzFilmyPokazywaneDanegoDnia(List<Seans> seanse, DateTime data)
        {
            return null;
        }

        /// <summary>
        /// Zwraca gatunek, z którego jest najwięcej filmów. Jeśli jest kilka takich
        /// gatunków, to zwraca dowolny z nich.
        /// </summary>
        /// <param name="filmy"></param>
        /// <returns></returns>
        public string NajpopularniejszyGatunek(List<Film> filmy)
        {
            // Właściwa odpowiedź: Obyczajowy
            return null;
        }

        public List<Sala> ZwrocSalePosortowanePoCalkowitejLiczbieMiejsc(List<Sala> sale)
        {
            // Właściwa odpowiedź: Kameralna, Bałtyk, Wisła (lub w odwrotnej kolejności)
            return null;
        }

        public Sala ZwrocSaleGdzieJestNajwiecejSeansow(List<Seans> seanse, DateTime data)
        {
            // Właściwa odpowiedź dla daty 2019-01-20: sala "Wisła" 
            return null;
        }

        /// <summary>
        /// Uwaga: Nie wszystkie parametry przekazane do metody muszą być użyte przy
        /// implementacji. Jeśli jest kilka takich filmów, zwracamy dowolny.
        /// </summary>
        /// <param name="filmy"></param>
        /// <param name="bilety"></param>
        /// <returns></returns>
        public Film ZwrocFilmNaKtorySprzedanoNajwiecejBiletow(List<Film> filmy, List<Bilet> bilety)
        {
            // Właściwa odpowiedź: "Konan Destylator"
            return null;
        }

        /// <summary>
        /// Uwaga: Nie wszystkie parametry metody muszą być wykorzystane przy
        /// implementacji. Filmy z takim samym przychodem zwracamy w dowolnej kolejności
        /// </summary>
        /// <param name="filmy"></param>
        /// <param name="bilety"></param>
        /// <returns></returns>
        public Film PosortujFilmyPoDochodach(List<Film> filmy, List<Bilet> bilety)
        {
            return null;
        }


    }
}
