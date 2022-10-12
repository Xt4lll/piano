using System;
using System.Data;
using System.Net.Http.Headers;

namespace piano
{
    internal class Program
    {

        static void Start()
        {
            Console.WriteLine("выберите октаву");
            Console.WriteLine("F4 - четвёртая октава");
            Console.WriteLine("F5 - пятая октава");
            Console.WriteLine("F6 - шестая октава");
            ConsoleKeyInfo oct = Console.ReadKey();
            switch (oct.Key)
            {
                case ConsoleKey.F4:
                    Octave4(Console.ReadKey());
                    break;
                case ConsoleKey.F5:
                    Octave5(Console.ReadKey());
                    break;
                case ConsoleKey.F6:
                    Octave6(Console.ReadKey());
                    break;
            }

        }
        static void Octave5(ConsoleKeyInfo key)
        {
            int[] octNotes = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 987 };
            while (key.Key != ConsoleKey.Escape)
            {
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(octNotes[0], 100);
                        break;
                    case ConsoleKey.D2:
                        Console.Beep(octNotes[1], 100);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(octNotes[2], 100);
                        break;
                    case ConsoleKey.D3:
                        Console.Beep(octNotes[3], 100);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(octNotes[4], 100);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(octNotes[5], 100);
                        break;
                    case ConsoleKey.D5:
                        Console.Beep(octNotes[6], 100);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(octNotes[7], 100);
                        break;
                    case ConsoleKey.D6:
                        Console.Beep(octNotes[8], 100);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(octNotes[9], 100);
                        break;
                    case ConsoleKey.D7:
                        Console.Beep(octNotes[10], 100);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(octNotes[11], 100);
                        break;
                    case ConsoleKey.F4:
                        Choose4();
                        break;
                    case ConsoleKey.F6:
                        Choose6();
                        break;
                }
                key = Console.ReadKey();
                Console.Clear();

            }
        }
        static void Octave6(ConsoleKeyInfo key)
        {
            int[] octNotes = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            while (key.Key != ConsoleKey.Escape)
            {
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(octNotes[0], 100);
                        break;
                    case ConsoleKey.D2:
                        Console.Beep(octNotes[1], 100);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(octNotes[2], 100);
                        break;
                    case ConsoleKey.D3:
                        Console.Beep(octNotes[3], 100);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(octNotes[4], 100);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(octNotes[5], 100);
                        break;
                    case ConsoleKey.D5:
                        Console.Beep(octNotes[6], 100);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(octNotes[7], 100);
                        break;
                    case ConsoleKey.D6:
                        Console.Beep(octNotes[8], 100);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(octNotes[9], 100);
                        break;
                    case ConsoleKey.D7:
                        Console.Beep(octNotes[10], 100);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(octNotes[11], 100);
                        break;
                    case ConsoleKey.F4:
                        Choose4();
                        break;
                    case ConsoleKey.F5:
                        Choose5();
                        break;
                }
                key = Console.ReadKey();
                Console.Clear();

            }
        }
            static void Octave4(ConsoleKeyInfo key)
            {
                int[] octNotes = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494};
                while (key.Key != ConsoleKey.Escape)
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.Q:
                            Console.Beep(octNotes[0], 100);
                            break;
                        case ConsoleKey.D2:
                            Console.Beep(octNotes[1], 100);
                            break;
                        case ConsoleKey.W:
                            Console.Beep(octNotes[2], 100);
                            break;
                        case ConsoleKey.D3:
                            Console.Beep(octNotes[3], 100);
                            break;
                        case ConsoleKey.E:
                            Console.Beep(octNotes[4], 100);
                            break;
                        case ConsoleKey.R:
                            Console.Beep(octNotes[5], 100);
                            break;
                        case ConsoleKey.D5:
                            Console.Beep(octNotes[6], 100);
                            break;
                        case ConsoleKey.T:
                            Console.Beep(octNotes[7], 100);
                            break;
                        case ConsoleKey.D6:
                            Console.Beep(octNotes[8], 100);
                            break;
                        case ConsoleKey.Y:
                            Console.Beep(octNotes[9], 100);
                            break;
                        case ConsoleKey.D7:
                            Console.Beep(octNotes[10], 100);
                            break;
                        case ConsoleKey.U:
                            Console.Beep(octNotes[11], 100);
                            break;
                    case ConsoleKey.F5:
                        Choose5();
                        break;
                    case ConsoleKey.F6:
                        Choose6();
                        break;
                }
                    key = Console.ReadKey();
                    Console.Clear();

                }
            }
                static void Choose5()
                {
                    Octave5(Console.ReadKey());
                }
                static void Choose6()
                {
                    Octave6(Console.ReadKey());
                }
                static void Choose4()
                {
                    Octave4(Console.ReadKey());
                }

        private static void Main(string[] args)
        {
            Start();
        }
    }
}