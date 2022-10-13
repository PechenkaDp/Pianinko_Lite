namespace Практическая3
{
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {
            Pianino();

        }

        static void Pianino()
        {
            Console.WriteLine("Доступные клавиши:");
            Console.WriteLine("Обычные: A-до; S-ре; D-ми; F-фа; G-соль; H-ля; J-си;");
            Console.WriteLine("Диезные и бемольные: W - До # и ре b; E - ми # и фа b; R- фа # и соль b; T- ля# и си b; Y- си # и до b.");
            Console.WriteLine("Переключение октавы: 1- F1; 2- F2; 3-F3.");
            Console.WriteLine("Для выхода нажмите Num9");


            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.F6)
            {
                oktava6();
            }
            if (key.Key == ConsoleKey.F5)
            {
                oktava5();
            }
            if (key.Key == ConsoleKey.F3)
            {
                oktava3();
            }
            if (key.Key == ConsoleKey.Backspace)
            {
                exit();
            }


        }


        static void oktava6()
        {
            Console.Clear();
            Console.WriteLine("Вы ввошли в шестую октаву");
            for (ConsoleKeyInfo k = Console.ReadKey(); k.Key != ConsoleKey.Backspace;)
            { 

                ConsoleKeyInfo l = Console.ReadKey();
                k = l;

            int[] oktava_1 = new int[12] { 1661, 1480, 1245, 1109, 932, 1568, 1397, 1319, 1175, 1047, 987, 880 };

            
        

            if (k.Key == ConsoleKey.A)
            {
                Console.Beep(oktava_1[oktava_1.Length - 1], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.S)
            {
                Console.Beep(oktava_1[oktava_1.Length - 2], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.D)
            {
                Console.Beep(oktava_1[oktava_1.Length - 3], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.F)
            {
                Console.Beep(oktava_1[oktava_1.Length - 4], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.G)
            {
                Console.Beep(oktava_1[oktava_1.Length - 5], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.H)
            {
                Console.Beep(oktava_1[oktava_1.Length - 6], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.J)
            {
                Console.Beep(oktava_1[oktava_1.Length - 7], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.W)
            {
                Console.Beep(oktava_1[oktava_1.Length - 8], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.E)
            {
                Console.Beep(oktava_1[oktava_1.Length - 9], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.R)
            {
                Console.Beep(oktava_1[oktava_1.Length - 10], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.T)
            {
                Console.Beep(oktava_1[oktava_1.Length - 11], 150);
                Console.Clear();
            }
            if (k.Key == ConsoleKey.Y)
            {
                Console.Beep(oktava_1[oktava_1.Length - 12], 150);
                Console.Clear();
            }

        }
            Pianino();
    }


        static void oktava5()
        {
            Console.Clear();
            Console.WriteLine("Вы ввошли во пятую октаву");
            for (ConsoleKeyInfo ke = Console.ReadKey(); ke.Key != ConsoleKey.Backspace;)
            {
                
                ConsoleKeyInfo l = Console.ReadKey();
                ke = l;

                int[] oktava_2 = new int[12] { 830, 740, 622, 554, 466, 784, 698, 659, 587, 523, 493, 440 };

                if (ke.Key == ConsoleKey.A)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 1], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.S)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 2], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.D)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 3], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.F)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.G)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.H)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 6], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.J)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 7], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.W)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 8], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.E)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 9], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.R)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 10], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.T)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 11], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.Y)
                {
                    Console.Beep(oktava_2[oktava_2.Length - 12], 100);
                    Console.Clear();
                }

                if (ke.Key == ConsoleKey.NumPad0)/*Sekretka*/
                {
                    Console.Beep(oktava_2[oktava_2.Length - 2], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 6], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 2], 100);
                    Thread.Sleep(500);

                    Console.Beep(oktava_2[oktava_2.Length - 1], 100);
                    Thread.Sleep(150);
                    Console.Beep(oktava_2[oktava_2.Length - 3], 100);
                    Thread.Sleep(150);
                    Console.Beep(oktava_2[oktava_2.Length - 2], 100);
                    Thread.Sleep(800);

                    Console.Beep(oktava_2[oktava_2.Length - 2], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 6], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Thread.Sleep(200);
                    Console.Beep(oktava_2[oktava_2.Length - 6], 100);
                    Thread.Sleep(400);

                    Console.Beep(oktava_2[oktava_2.Length - 6], 100);
                    Thread.Sleep(150);
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Thread.Sleep(150);
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Thread.Sleep(150);

                    Console.Beep(oktava_2[oktava_2.Length - 6], 100);
                    Thread.Sleep(150);
                    Console.Beep(oktava_2[oktava_2.Length - 5], 100);
                    Thread.Sleep(150);
                    Console.Beep(oktava_2[oktava_2.Length - 4], 100);
                    Thread.Sleep(150);

                    Console.Beep(oktava_2[oktava_2.Length - 2], 100);
                    Thread.Sleep(200);
                    Console.Clear();

                }

            }
            Pianino();
        }

        static void oktava3()
        {
            Console.Clear();
            for (ConsoleKeyInfo k = Console.ReadKey(); k.Key != ConsoleKey.Backspace;)
            {
                ConsoleKeyInfo l = Console.ReadKey();
                k = l;

                int[] oktava_1 = new int[12] { 207, 185, 155, 138, 116, 196, 174, 164, 146, 130, 123, 110 };




                if (k.Key == ConsoleKey.A)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 1], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.S)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 2], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.D)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 3], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.F)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 4], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.G)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 5], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.H)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 6], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.J)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 7], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.W)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 8], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.E)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 9], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.R)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 10], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.T)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 11], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.Y)
                {
                    Console.Beep(oktava_1[oktava_1.Length - 12], 150);
                    Console.Clear();
                }
               
                    
                
            }
            Pianino();

        }
            static void exit()
        {
            Console.Clear();
            Console.WriteLine("Завершение программы");
        }

           
        
    }
}