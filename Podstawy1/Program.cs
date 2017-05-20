using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podstawy1
{
    class User {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
    }
    class Robocza {
        public string Dzien(int nrDnia) {
            switch (nrDnia) {
                case 1:
                    return "Poniedziałek";
                case 2:
                    return "Wtorek";
                case 3:
                    return "Środa";
                case 4:
                    return "Czwartek";
                case 5:
                    return "Piątek";
                case 6:
                    return "Sobota";
                case 7:
                    return "Niedziela";
                default:
                    return "błędny numer";
            }
        }

        public List<User> GetUsers() {
            return new List<User> {
                new User() {Imie = "Adam",Nazwisko = "Nowak",Wiek = 23},
                new User() {Imie = "Roman",Nazwisko = "Kowal",Wiek = 45},
                new User() {Imie = "Anna",Nazwisko = "Pałka",Wiek = 26},
                new User() {Imie = "Tomasz",Nazwisko = "Jonasz",Wiek = 33},
                new User() {Imie = "Zuzanna",Nazwisko = "Urych",Wiek = 23},
            };
        }

    }
    class Program
    {
        static void Main(string[] args) {

           Robocza r1 = new Robocza();//tworzenie obiektu r1 typu Robocza
           // int nr = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(r1.Dzien(nr));
            List<User> lista = r1.GetUsers();
            IQueryable<User> wybrane = lista.AsQueryable()
                .Where(e => (e.Wiek > 25));
            IQueryable<User> wybrane2 = lista.AsQueryable()
                .Where(e => (e.Imie.EndsWith("a")));
            IQueryable<User> wybrane3 = lista.AsQueryable()
                .Where(e => (e.Imie.EndsWith("a") && e.Wiek<25));
            foreach (User user in wybrane3) {
                Console.WriteLine(user.Imie+" "+user.Nazwisko+" wiek: "
                       +user.Wiek);
            }
            Console.ReadKey();
        }
    }
}
