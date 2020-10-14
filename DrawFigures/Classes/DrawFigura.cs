using System;
using System.Collections.Generic;
using System.Text;

namespace DrawFigures
{
    public delegate void DrawFigureDelegate(ConsoleColor color);
    static class DrawFigura
    {
        private static void DrawRectangle(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            int width = 20;
            int height = 10;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        if (j == 0 || j == width - 1)
                        {
                            Console.Write("@");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        private static void DrawTriangle(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            int height = 10;
            for (int i = 0; i < height - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < height - 1; i++)
            {
                Console.Write("@");
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void DrawFigureMenu()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                DrawFigureDelegate drawFigureDelegate = new DrawFigureDelegate(DrawRectangle);
                drawFigureDelegate += DrawTriangle;


                int counter = 1;
                ConsoleKeyInfo keyInfo;
                do
                {
                    Console.Clear();
                    Console.ResetColor();
                    if (counter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("1. Червоний");
                    Console.ResetColor();

                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("2. Жовтий");
                    Console.ResetColor();

                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("3. Чорний");
                    Console.ResetColor();

                    if (counter == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine("4. Зелений");
                    Console.ResetColor();

                    if (counter == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine("5. Синій");
                    Console.ResetColor();

                    if (counter == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.WriteLine("6. Оранжевий");
                    Console.ResetColor();

                    if (counter == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.WriteLine("7. Сірий");
                    Console.ResetColor();

                    if (counter == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    Console.WriteLine("8. Блакитний");
                    Console.ResetColor();



                    keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (counter > 1)
                                {
                                    counter--;
                                }
                                break;
                            }

                        case ConsoleKey.DownArrow:
                            {
                                if (counter < 8)
                                {
                                    counter++;
                                }
                                break;
                            }
                    }


                } while (keyInfo.Key != ConsoleKey.Enter);

                ConsoleColor color;

                switch (counter)
                {
                    case 1: { color = ConsoleColor.Red; break; }
                    case 2: { color = ConsoleColor.Yellow; break; }
                    case 3: { color = ConsoleColor.Black; break; }
                    case 4: { color = ConsoleColor.Green; break; }
                    case 5: { color = ConsoleColor.Blue; break; }
                    case 6: { color = ConsoleColor.DarkYellow; break; }
                    case 7: { color = ConsoleColor.Gray; break; }
                    case 8: { color = ConsoleColor.Cyan; break; }
                    default: { color = ConsoleColor.White; break; }
                }

                Console.Clear();
                drawFigureDelegate(color);
                Console.ReadKey();
            }
        }
    }
}
