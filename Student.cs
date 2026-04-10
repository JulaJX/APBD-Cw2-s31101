using System.Collections.Generic;

namespace Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Email { get; set; }
        public List<double> Oceny { get; set; } = new List<double>();
    }
}