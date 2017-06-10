using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirst.Models
{
    public class Gra
    {
        public string Nazwa { get; set; }
        public string Gatunek { get; set; }
        public string Opis { get; set; }
        public int Ocena { get; set; }
        public string UrlImg { get; set; }
    }
}