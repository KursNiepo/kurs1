using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursDemo1WebForm.Models
{
    public class PersonRepo {
        private List<Person> lista;
        public PersonRepo() {
            lista = new List<Person>();
        }

        public List<Person> GetAll() {
            lista.Add(new Person {Imie = "Adam",Nazwisko = "Nowak",
                    DataUrodzenia = new DateTime(1997,9,5),Pensja = 3500});
            lista.Add(new Person
            {
                Imie = "Monika",
                Nazwisko = "Urych",
                DataUrodzenia = new DateTime(1999, 11, 5),
                Pensja = 3500
            });
            lista.Add(new Person
            {
                Imie = "Janusz",
                Nazwisko = "Gajos",
                DataUrodzenia = new DateTime(2005, 4, 12),
                Pensja = 3500
            });
            lista.Add(new Person
            {
                Imie = "Henryk",
                Nazwisko = "Walezy",
                DataUrodzenia = new DateTime(2001, 4, 23),
                Pensja = 3500
            });
            lista.Add(new Person
            {
                Imie = "Tomasz",
                Nazwisko = "Konek",
                DataUrodzenia = new DateTime(1994, 2, 15),
                Pensja = 3500
            });
            return lista;
        }
    }
}