using System.Collections.Generic;

namespace Linq
{
    public static class DaneUczelni
    {
        public static List<Student> Studenci = new List<Student>
        {
            new Student { Id = 1, Imie = "Anna",  Nazwisko = "Nowak",      Miasto = "Poznań",   Email = "anna@wp.pl",  Oceny = new List<double>{ 5, 4, 4.5 } },
            new Student { Id = 2, Imie = "Jan",   Nazwisko = "Kowalski",   Miasto = "Warszawa", Email = "jan@wp.pl",   Oceny = new List<double>{ 3, 4 } },
            new Student { Id = 3, Imie = "Ewa",   Nazwisko = "Mazur",      Miasto = "Kraków",   Email = "ewa@wp.pl",   Oceny = new List<double>{ 5, 5 } },
            new Student { Id = 4, Imie = "Piotr", Nazwisko = "Zieliński",  Miasto = "Warszawa", Email = "piotr@wp.pl", Oceny = new List<double>{ 3.5, 4 } }
        };

        public static List<Przedmiot> Przedmioty = new List<Przedmiot>
        {
            new Przedmiot { Id = 1, Nazwa = "C#" },
            new Przedmiot { Id = 2, Nazwa = "SQL" },
            new Przedmiot { Id = 3, Nazwa = "LINQ" }
        };

        public static List<Zapis> Zapisy = new List<Zapis>
        {
            new Zapis { IdStudenta = 1, IdPrzedmiotu = 1, CzyAktywny = true },
            new Zapis { IdStudenta = 1, IdPrzedmiotu = 3, CzyAktywny = true },
            new Zapis { IdStudenta = 2, IdPrzedmiotu = 2, CzyAktywny = true },
            new Zapis { IdStudenta = 3, IdPrzedmiotu = 1, CzyAktywny = false },
            new Zapis { IdStudenta = 4, IdPrzedmiotu = 3, CzyAktywny = true }
        };
    }
}