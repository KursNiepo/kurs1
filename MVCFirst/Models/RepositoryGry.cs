using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirst.Models
{
    public class RepositoryGry
    {
        public static List<Gra> GetAll() {
            return new List<Gra>() {
                new Gra() {Nazwa = "PayDay",
                    Gatunek = "Taktyczny FPS",
                    Opis = "Taktyczna gra akcji rabunek banku",
                    Ocena = 5,
                    UrlImg = @"/Content/obrazki/payday.jpg"
                },
                new Gra() {Nazwa = "Torment",
                    Gatunek = "RPG",
                    Opis = "Powrót po latach..",
                    Ocena = 4,
                    UrlImg = @"/Content/obrazki/payday.jpg"
                },
                new Gra() {Nazwa = "BF3",
                    Gatunek = "Taktyczny FPS",
                    Opis = "Taktyczna gra wojenna",
                    Ocena = 5,
                    UrlImg = @"/Content/obrazki/bf3.jpg"
                },
                new Gra() {Nazwa = "BF4",
                    Gatunek = "TaktycznyFPS",
                    Opis = "Taktyczna gra wojenna",
                    Ocena = 4,
                    UrlImg = @"/Content/obrazki/bf3.jpg"
                },
                new Gra() {Nazwa = "Diablo 3",
                    Gatunek = "Action RPG",
                    Opis = "Kiedyś legenda teraz ...",
                    Ocena = 3,
                    UrlImg = @"/Content/obrazki/d3.jpg"
                },
            };
        }
    }
}