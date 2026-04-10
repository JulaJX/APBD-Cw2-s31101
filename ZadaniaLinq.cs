using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class ZadaniaLinq
    {
        public static IEnumerable<string> StudenciZWarszawy() =>
            DaneUczelni.Studenci
                .Where(s => s.Miasto == "Warszawa")
                .Select(s => $"{s.Imie} {s.Nazwisko}");

        public static IEnumerable<string> MaileStudentow() =>
            DaneUczelni.Studenci
                .Select(s => s.Email);

        public static IEnumerable<string> SortowanieStudentow() =>
            DaneUczelni.Studenci
                .OrderBy(s => s.Nazwisko)
                .ThenBy(s => s.Imie)
                .Select(s => $"{s.Nazwisko} {s.Imie}");

        public static IEnumerable<string> PierwszyStudentZPoznania()
        {
            var s = DaneUczelni.Studenci.FirstOrDefault(x => x.Miasto == "Poznań");
            return new[] { s == null ? "Brak" : $"{s.Imie} {s.Nazwisko}" };
        }

        public static IEnumerable<string> CzySaAktywneZapisy() =>
            new[] { DaneUczelni.Zapisy.Any(z => z.CzyAktywny) ? "Tak" : "Nie" };

        public static IEnumerable<string> CzyWszyscyMajaMail() =>
            new[] { DaneUczelni.Studenci.All(s => !string.IsNullOrWhiteSpace(s.Email)) ? "Tak" : "Nie" };

        public static IEnumerable<string> LiczbaStudentowZWarszawy() =>
            new[] { DaneUczelni.Studenci.Count(s => s.Miasto == "Warszawa").ToString() };

        public static IEnumerable<string> MiastaBezDuplikatow() =>
            DaneUczelni.Studenci
                .Select(s => s.Miasto)
                .Distinct()
                .OrderBy(m => m);

        public static IEnumerable<string> StronicowanieStudentow() =>
            DaneUczelni.Studenci
                .Skip(1)
                .Take(2)
                .Select(s => $"{s.Imie} {s.Nazwisko}");

        public static IEnumerable<string> StudentIPrzedmiot() =>
            DaneUczelni.Studenci
                .Join(DaneUczelni.Zapisy, s => s.Id, z => z.IdStudenta, (s, z) => new { s, z.IdPrzedmiotu })
                .Join(DaneUczelni.Przedmioty, x => x.IdPrzedmiotu, p => p.Id, (x, p) => $"{x.s.Imie} {x.s.Nazwisko} -> {p.Nazwa}");

        public static IEnumerable<string> GrupyPoMiescie() =>
            DaneUczelni.Studenci
                .GroupBy(s => s.Miasto)
                .Select(g => $"{g.Key}: {g.Count()}");

        public static IEnumerable<string> SredniaIMax() =>
            DaneUczelni.Studenci
                .Select(s => $"{s.Imie}: średnia {s.Oceny.Average():0.00}, max {s.Oceny.Max():0.00}");
    }
}