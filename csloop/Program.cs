using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;

            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복");

            String[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int x = 1;
            while (x < 50)
            {
                //화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                //100밀리초 정지하고 X를 증가합니다.
                Thread.Sleep(100);
                x++;
            }

            //switch 조건문과 무한 반복문
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        break;
                }

                //개선된 switch 조건문(자주 애용되는 패턴)
                bool state = true;
                while (state)
                {
                    ConsoleKeyInfo infom = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.WriteLine("위로 이동");
                            break;
                        case ConsoleKey.RightArrow:
                            Console.WriteLine("오른쪽으로 이동");
                            break;
                        case ConsoleKey.DownArrow:
                            Console.WriteLine("아래로 이동");
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.WriteLine("왼쪽으로 이동");
                            break;
                        case ConsoleKey.X:
                            state = false;
                            break;
                    }
                }
            }
        }
    }
}
