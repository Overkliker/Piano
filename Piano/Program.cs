using System;
using System.Media;

namespace Piano
{
    public class Programm
    {
        static void Main(string[] argrs)
        {
            bool flag = false;
            Octave piano = new Octave();
            piano.upOct();
            

            while (!flag)
            {
                if (piano.oct != 5)
                {
                    Console.WriteLine("Клавиши для игры на пианино: q, w, e, r, t, y, u, i, o, p, f, h");
                }
                else
                {
                    Console.WriteLine("Клавиши для игры на пианино: q, w, e, r, t");
                }
                
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        piano.sound("q");
                        break;

                    case ConsoleKey.W:
                        piano.sound("w");
                        break;

                    case ConsoleKey.E:
                        piano.sound("e");
                        break;

                    case ConsoleKey.R:
                        piano.sound("r");
                        break;

                    case ConsoleKey.T:
                        piano.sound("t");
                        break;

                    case ConsoleKey.Y:
                        piano.sound("y");
                        break;

                    case ConsoleKey.U:
                        piano.sound("u");
                        break;

                    case ConsoleKey.I:
                        piano.sound("i");
                        break;

                    case ConsoleKey.O:
                        piano.sound("o");
                        break;

                    case ConsoleKey.P:
                        piano.sound("p");
                        break;

                    case ConsoleKey.F:
                        piano.sound("f");
                        break;

                    case ConsoleKey.H:
                        piano.sound("h");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Такой клавиши нету.");
                        break;
                        
                }



                /////////// Смена октавы //////////
                if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F1)
                {
                    piano.setOctave(0);
                    Console.WriteLine("вы поставили октаву номер " + piano.oct);
                }
                else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F2)
                {
                    piano.setOctave(1);
                    Console.WriteLine("вы поставили октаву номер " + piano.oct);
                }
                else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F3)
                {
                    piano.setOctave(2);
                    Console.WriteLine("вы поставили октаву номер " + piano.oct);
                }
                else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F4)
                {
                    piano.setOctave(3);
                    Console.WriteLine("вы поставили октаву номер " + piano.oct);
                }
                else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F5)
                {
                    piano.setOctave(4);
                    Console.WriteLine("вы поставили октаву номер " + piano.oct);
                }
                else if (key.Modifiers.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.F6)
                {
                    piano.setOctave(5);
                    Console.WriteLine("вы поставили октаву номер " + piano.oct);
                }
                }
                
            }
        }
    
}