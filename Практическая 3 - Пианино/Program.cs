using static System.Net.Mime.MediaTypeNames;

namespace Практическая_3___Пианино
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OctavaChange();
        }

        static void SOund(int meow)
        {
            Console.Beep(meow, 200);
            Console.Clear();
        }
        static void OctavaF4()
        {
            Console.Clear();
            int[] OctavaF4White = new int[] { 261, 293, 329, 349, 392, 440, 493};
            int[] OctavaF4Black = new int[] { 277, 311, 370, 415, 466 };
            Console.WriteLine("Вы перешли в октаву 4");
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Escape)
            {
                ConsoleKeyInfo clavisha1 = Console.ReadKey();
                if (clavisha1.Key == ConsoleKey.Z) // До(C)
                {
                    SOund(OctavaF4White[0]);
                }
                else if (clavisha1.Key == ConsoleKey.X)
                {
                    SOund(OctavaF4White[1]);
                }
                else if (clavisha1.Key == ConsoleKey.C)
                {
                    SOund(OctavaF4White[2]);
                }
                else if (clavisha1.Key == ConsoleKey.Q)
                {
                    SOund(OctavaF4White[3]);
                }
                else if (clavisha1.Key == ConsoleKey.W)
                {
                    SOund(OctavaF4White[4]);
                }
                else if (clavisha1.Key == ConsoleKey.E)
                {
                    SOund(OctavaF4White[5]);
                }
                else if (clavisha1.Key == ConsoleKey.R)
                {
                    SOund(OctavaF4White[6]);
                }
                else if (clavisha1.Key == ConsoleKey.Escape)
                {
                    Exit();
                }
                else if (clavisha1.Key == ConsoleKey.S)
                {
                    SOund(OctavaF4Black[0]);
                }
                else if (clavisha1.Key == ConsoleKey.D)
                {
                    SOund(OctavaF4Black[1]);
                }
                else if (clavisha1.Key == ConsoleKey.D2)
                {
                    SOund(OctavaF4Black[2]);
                }
                else if (clavisha1.Key == ConsoleKey.D3)
                {
                    SOund(OctavaF4Black[3]);
                }
                else if (clavisha1.Key == ConsoleKey.D4)
                {
                    SOund(OctavaF4Black[4]);
                }
                else if (clavisha1.Key == ConsoleKey.F5)
                {
                    OctavaF5();
                    Console.Clear();
                }
                else if (clavisha1.Key == ConsoleKey.Delete)
                {
                    Reference();
                }
            }
            Exit();
        }
        static void OctavaF5()
        {
            int time = 200;
            Console.Clear();
            int[] OctavaF5White = new int[] { 523, 587, 659, 698, 784, 880, 987 };
            int[] OctavaF5Black = new int[] { 554, 622, 740, 830, 932 };
            Console.WriteLine("Вы перешли в октаву 5");
            ConsoleKeyInfo clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Escape)
            {
                ConsoleKeyInfo clavisha1 = Console.ReadKey();
                if (clavisha1.Key == ConsoleKey.Z)
                {
                    SOund(OctavaF5White[0]);
                }
                else if (clavisha1.Key == ConsoleKey.X)
                {
                    SOund(OctavaF5White[1]);
                }
                else if (clavisha1.Key == ConsoleKey.C)
                {
                    SOund(OctavaF5White[2]);
                }
                else if (clavisha1.Key == ConsoleKey.Q)
                {
                    SOund(OctavaF5White[3]);
                }
                else if (clavisha1.Key == ConsoleKey.W)
                {
                    SOund(OctavaF5White[4]);
                }
                else if (clavisha1.Key == ConsoleKey.E)
                {
                    SOund(OctavaF5White[5]);
                }
                else if (clavisha1.Key == ConsoleKey.Escape)
                {
                    Exit();
                }
                else if (clavisha1.Key == ConsoleKey.S)
                {
                    SOund(OctavaF5Black[0]);
                }
                else if (clavisha1.Key == ConsoleKey.D)
                {
                    SOund(OctavaF5White[1]);
                }
                else if (clavisha1.Key == ConsoleKey.D2)
                {
                    SOund(OctavaF5White[2]);
                }
                else if (clavisha1.Key == ConsoleKey.D3)
                {
                    SOund(OctavaF5White[3]);
                }
                else if (clavisha1.Key == ConsoleKey.D4)
                {
                    SOund(OctavaF5White[4]);
                }
                else if (clavisha1.Key == ConsoleKey.F4)
                {
                    OctavaF4();
                    Console.Clear();
                }
                else if (clavisha1.Key == ConsoleKey.Delete)
                {
                    Reference();
                }
            }
            Exit();
        }
        static void OctavaChange()
        {
            Info();
            ConsoleKeyInfo clavisha = Console.ReadKey();
            if (clavisha.Key == ConsoleKey.F4)
            {
                OctavaF4();
            }
            else if (clavisha.Key == ConsoleKey.F5)
            {
                OctavaF5();
            }
            else if (clavisha.Key == ConsoleKey.Escape)
            {
                Exit();
            }
            else if (clavisha.Key == ConsoleKey.Delete)
            {
                Reference();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Вы что-то не то ввели");
                OctavaChange();
            }
        }
        static void Info()
        {
            Console.WriteLine("Переключение между октавами - F4 и F5");
            Console.WriteLine("Выйти из программы - esc");
            Console.WriteLine("Справка - Delete");
            Console.WriteLine("ВЫБЕРИТЕ ОКТАВУ");
        }
        static void Reference()
        {
            Console.Clear();
            Console.WriteLine("До - Z");
            Console.WriteLine("Ре - X");
            Console.WriteLine("Ми - C");
            Console.WriteLine("Фа - Q");
            Console.WriteLine("Соль - W");
            Console.WriteLine("Ля - E");
            Console.WriteLine("Си - R");
            Console.WriteLine("До# - S");
            Console.WriteLine("Ре# - D");
            Console.WriteLine("Фа# - 2");
            Console.WriteLine("Соль# - 3");
            Console.WriteLine("Ля# - 4");
            Console.WriteLine("Октава 4 - F4");
            Console.WriteLine("Октава 5 - F5");
            Console.WriteLine("Справка - Delete");
            Console.WriteLine("Выход - Esc");
            Console.WriteLine(" ");
            OctavaChange();
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("ВВы вышли из программы");
            Environment.Exit(0);
        }
    }
}