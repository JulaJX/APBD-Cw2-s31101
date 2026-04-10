using System;
using System.Collections.Generic;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU LINQ ===");
                Console.WriteLine("1. Studenci z Warszawy");
                Console.WriteLine("2. Maile studentów");
                Console.WriteLine("3. Sortowanie studentów");
                Console.WriteLine("4. Pierwszy student z Poznania");
                Console.WriteLine("5. Czy są aktywne zapisy?");
                Console.WriteLine("6. Czy wszyscy mają mail?");
                Console.WriteLine("7. Ilu studentów z Warszawy?");
                Console.WriteLine("8. Miasta bez duplikatów");
                Console.WriteLine("9. Skip/Take");
                Console.WriteLine("10. Student i przedmiot");
                Console.WriteLine("11. Grupy po mieście");
                Console.WriteLine("12. Średnia i max ocen");
                Console.WriteLine("0. Koniec");
                Console.Write(" ");
                Console.Write("Wybór: ");
                Console.Write(" ");

                var wybor = Console.ReadLine();
                if (wybor == "0") break;

                IEnumerable<string> wynik = wybor switch
                {
                    "1" => ZadaniaLinq.StudenciZWarszawy(),
                    "2" => ZadaniaLinq.MaileStudentow(),
                    "3" => ZadaniaLinq.SortowanieStudentow(),
                    "4" => ZadaniaLinq.PierwszyStudentZPoznania(),
                    "5" => ZadaniaLinq.CzySaAktywneZapisy(),
                    "6" => ZadaniaLinq.CzyWszyscyMajaMail(),
                    "7" => ZadaniaLinq.LiczbaStudentowZWarszawy(),
                    "8" => ZadaniaLinq.MiastaBezDuplikatow(),
                    "9" => ZadaniaLinq.StronicowanieStudentow(),
                    "10" => ZadaniaLinq.StudentIPrzedmiot(),
                    "11" => ZadaniaLinq.GrupyPoMiescie(),
                    "12" => ZadaniaLinq.SredniaIMax(),
                    _ => new[] { "Zła opcja" }
                };

                foreach (var x in wynik)
                    Console.WriteLine(x);
                
            }

        }
    }
}