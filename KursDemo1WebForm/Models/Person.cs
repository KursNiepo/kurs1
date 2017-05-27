using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursDemo1WebForm.Models
{
    public class Person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public decimal Pensja { get; set; }
    }
}