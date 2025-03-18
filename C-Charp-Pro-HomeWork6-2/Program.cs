//Создайте класс «Магазин», который должен хранить следующую информацию:
//название магазина;
//адреса магазина;
//тип магазина: продовольственная, хозяйственная, одежда, обувь.
//Реализуйте в классе методы и свойства, необходимые для работы класса.
//Класс должен реализовывать интерфейс IDisposable.
//Напишите код тестирования функциональности класса.
//Напишите код для вызова по методу Dispose.

using C_Charp_Pro_HomeWork6_2;
using System.Xml.Linq;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("");
        string name = Console.ReadLine();

        Console.WriteLine("");
        string address = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("");
        int storeTypeNum = int.Parse(Console.ReadLine());
        string storeType = Enum.GetName(typeof(StoreType), storeTypeNum);

        Shop play = new Shop(name, address, storeType);

        play.Show();

        play.Dispose();
    }
}