namespace Pivanino
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" ");
            Console.WriteLine("привет! это синтезатор `Pivanino`");
            Console.WriteLine("можно включить 1 или 2 октаву.");
            Console.WriteLine("октавы включаются кнопочками Fn с соответствующими номерами.");
            Console.Write("выбирайте октаву:3");
            ConsoleKeyInfo NumberOctave = Console.ReadKey();

            if (NumberOctave.Key == ConsoleKey.F1)
            {
                Octave1();
            }
            if (NumberOctave.Key == ConsoleKey.F2)
            {
                Octave2();
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("такую октаву я включить не могу:(");
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }

        }
        static void Octave1()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 октава!");
            Console.WriteLine("-чтобы вернуться в менюшку жмите (Home)");
            Console.WriteLine(" \n" +
                                "подсказка! жми:\n" +
                                "K K K K H\n" +
                                "H H H H H H H H H H\n" +
                                "H H H H H H Y Y Y F Y\n" +
                                "Y Y Y H\n" +
                                " \n" +
                                "и получится Дайте Танк(!):>");

            while (true)
            {
                int[] octave1 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493, 523 };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.S)
                {
                    Sound(octave1[0]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    Sound(octave1[1]);
                }

                if (key.Key == ConsoleKey.D)
                {
                    Sound(octave1[2]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Sound(octave1[3]);
                }

                if (key.Key == ConsoleKey.F)
                {
                    Sound(octave1[4]);
                }

                if (key.Key == ConsoleKey.G)
                {
                    Sound(octave1[5]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Sound(octave1[6]);
                }

                if (key.Key == ConsoleKey.H)
                {
                    Sound(octave1[7]);
                }

                if (key.Key == ConsoleKey.U)
                {
                    Sound(octave1[8]);
                }

                if (key.Key == ConsoleKey.J)
                {
                    Sound(octave1[9]);
                }

                if (key.Key == ConsoleKey.I)
                {
                    Sound(octave1[10]);
                }

                if (key.Key == ConsoleKey.K)
                {
                    Sound(octave1[11]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    Sound(octave1[12]);
                }

                if (key.Key == ConsoleKey.Home)
                {
                    Main();
                }
            }
        }
        static void Octave2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("2 октава!");
            Console.WriteLine("-чтобы вернуться в менюшку жмайте (Home)");
            Console.WriteLine(" \n" +
                               "подсказка! жмите:\n" +
                               "G F F D D\n" +
                               "G F D\n" +
                               "D F G I J J G G\n" +
                               "I J F\n" +
                               " \n" +
                               "и получится Король и Шут:)\n");

            while (true)
            {
                int[] octave2 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987, 1046 };
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.S)
                {
                    Sound(octave2[0]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    Sound(octave2[1]);
                }

                if (key.Key == ConsoleKey.D)
                {
                    Sound(octave2[2]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    Sound(octave2[3]);
                }

                if (key.Key == ConsoleKey.F)
                {
                    Sound(octave2[4]);
                }

                if (key.Key == ConsoleKey.G)
                {
                    Sound(octave2[5]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    Sound(octave2[6]);
                }

                if (key.Key == ConsoleKey.H)
                {
                    Sound(octave2[7]);
                }

                if (key.Key == ConsoleKey.U)
                {
                    Sound(octave2[8]);
                }

                if (key.Key == ConsoleKey.J)
                {
                    Sound(octave2[9]);
                }

                if (key.Key == ConsoleKey.I)
                {
                    Sound(octave2[10]);
                }

                if (key.Key == ConsoleKey.K)
                {
                    Sound(octave2[11]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    Sound(octave2[12]);
                }

                if (key.Key == ConsoleKey.Home)
                {
                    Main();
                }
            }
        }
        static void Sound(int ruchki)
        {
            Console.Beep(ruchki, 110);

        }
    }
}