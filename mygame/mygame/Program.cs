using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mygame
{
    class Program
    {
        static void Main(string[] args)
        {
            try //пытаемся создать игру
            {
                var game = new Game_3(Reader.read("G:\\Новый текстовый документ.txt")); //создаем игру
                while (!game.WIN()) //играем пока не достигнем победы
                {
                    Draw.Print(game); //рисуем игру
                    try
                    {
                        Console.WriteLine("ВВедите число которое хотите передвинуть");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        while (!game.Shift(choise))
                        {
                            Console.WriteLine("Введите другое число");
                            choise = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Console.Clear();
                }
                Draw.Print(game);

            }
            catch (Exception) //если игра не может быть создана выскочит это исключение 
            {
                Console.WriteLine("Игра не может быть создана");
            }
            Console.Read();
        }
    }
}
