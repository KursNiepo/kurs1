using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursDemo1WebForm.Models
{
    public class Person {
        private DateTime dataurodzenia;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia {
            get { return dataurodzenia.Date; }
            set { dataurodzenia = value; }
             }
        public decimal Pensja { get; set; }
    }
}