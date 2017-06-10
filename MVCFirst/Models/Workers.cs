using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirst.Models
{
    public class Workers
    {
        public List<Worker> GetAll() {
            List<Worker> lista = new List<Worker>();
            lista.Add(new Worker() {FirstName = "Adam",LastName = "Nowak",
                                    Salary = 2400m});
            lista.Add(new Worker()
            {
                FirstName = "Monika",
                LastName = "Rusek",
                Salary = 3400m
            });
            lista.Add(new Worker()
            {
                FirstName = "Mariusz",
                LastName = "Adamiak",
                Salary = 2800m
            });
            lista.Add(new Worker()
            {
                FirstName = "Teresa",
                LastName = "Metresa",
                Salary = 1400m
            });
            return lista;
        }
    }
}