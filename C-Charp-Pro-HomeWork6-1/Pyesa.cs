using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Charp_Pro_HomeWork6_1
{
    public class Pyesa : IDisposable
    {
        public string Name;
        public string FullName;
        public string Genre;
        public int Year;

        public Pyesa(string name, string fullName, string genre, int year)
        {
            this.Name = name;
            this.FullName = fullName;
            this.Genre = genre;
            this.Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Full Name: {this.FullName}, Genre: {this.Genre}, Year: {this.Year}");
        }

        public void Dispose()
        {
            Console.WriteLine("Removing something there... v1");
        }

        ~Pyesa()
        {
            Console.WriteLine("Removing something there... v2");
        }
    }
}
