//Создайте класс «Пьеса», который должен хранить следующую информацию:
//название пьесы;
//Ф.И.О.автора;
//жанр;
//год.
//Реализуйте в классе методы и свойства, необходимые для работы класса.
//Добавьте в класс деструктор.
//Напишите код тестирования функциональности класса.
//Напишите код для деструктора.


using C_Charp_Pro_HomeWork6_1;
using C_Charp_Pro_HomeWork6_1.Enums;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("");
        string name = Console.ReadLine();

        Console.WriteLine("");
        string fullName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("");
        int genreNum = int.Parse(Console.ReadLine());
        string genre = Enum.GetName(typeof(Genre), genreNum);

        Console.WriteLine("");
        int year = int.Parse(Console.ReadLine());

        Pyesa play = new Pyesa(name, fullName, genre, year);

        play.Show();

        play.Dispose();
    }
}
