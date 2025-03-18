using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Charp_Pro_HomeWork6_2
{
    internal class Shop : IDisposable
    {
        public string Name;
        public string Address;
        public string StoreType;

        public Shop(string name, string address, string storeType)
        {
            this.Name = name;
            this.Address = address;
            this.StoreType = storeType;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Address: {this.Address}, StoreType: {this.StoreType}");
        }

        public void Dispose()
        {
            Console.WriteLine("Removing something there... v1");
        }

        ~Shop()
        {
            Console.WriteLine("Removing something there... v2");
        }
    }
}
