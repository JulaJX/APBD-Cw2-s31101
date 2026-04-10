using System;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in DaneUczelni.Studenci)
            {
                Console.WriteLine(s);
            }
        }
    }
}