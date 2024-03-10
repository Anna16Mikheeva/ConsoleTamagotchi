using System;
using System.Threading;

namespace Tamagotchi
{
    /// <summary>
    /// Класс состояния питомца.
    /// </summary>
    internal class TamagotchiCondition
    {
        /// <summary>
        /// Экземпляр класса PetActions.
        /// </summary>
        private TamagotchiActions _tamagotchiActions = new TamagotchiActions();

        /// <summary>
        /// Номер действия в меню.
        /// </summary>
        private string numberMenu;

        /// <summary>
        /// Массив состояния питомца.
        /// </summary>
        string[] _statePet = {"----------",
                              "+---------",
                              "++--------",
                              "+++-------",
                              "++++------",
                              "+++++-----",
                              "++++++----",
                              "+++++++---",
                              "++++++++--",
                              "+++++++++-",
                              "++++++++++" };

        /// <summary>
        /// Функция снижения состояния питомца со временем.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void DowngradeState(Tamagotchi tamagotchi)
        {
            // Бесконечный цикл.
            while (true)
            {
                // Пауза минута.
                Thread.Sleep(60000);

                StartGame();

                // Вывод имени питомца.
                Console.WriteLine(tamagotchi.Name);

                GetSick(tamagotchi);

                _tamagotchiActions.IncreaseState(tamagotchi);

                DisplayStateMenu(tamagotchi);
            }
        }

        /// <summary>
        /// Вывод информации о питомце и меню.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void PrintInformationPet(Tamagotchi tamagotchi)
        {
            StartGame();

            if (tamagotchi.Name.Length == 0)
            {
                tamagotchi.Name = Console.ReadLine();
                while (tamagotchi.Name.Length == 0)
                {
                    PrintInformationPet(tamagotchi);
                }

                // Создание экземпляра класса Thread и указание метода,
                // который будет выполнять в другом потоке.
                Thread myThread = new Thread(() => DowngradeState(tamagotchi));
                // Запуск потока.
                myThread.Start();
            }
            else
            {
                // Вывод имени питомца.
                Console.WriteLine(tamagotchi.Name);
            }

            GetSick(tamagotchi);

            DisplayStateMenu(tamagotchi);

            EnterActionNumber(tamagotchi);
        }

        // Вывод типа питомца и предложения ввести имя.
        public void StartGame()
        {
            // Очищение консоли.
            Console.Clear();
            // Вывод типа питомца.
            Console.WriteLine("###########################################################\n" +
               "############################ CAT ##########################\n" +
               "###########################################################\n\n");
            // Вывод сообщения с именем питомца.
            Console.WriteLine("Pet's name: ");
        }

        // Вывод, что питомец болен.
        public void GetSick(Tamagotchi tamagotchi)
        {
            // Условие, что состояние здоровья равно 0.
            if (tamagotchi.Health == 0)
            {
                // Вывод сообщения, что питомец болен.
                Console.WriteLine("!!!The pet is sick!!!");
            }
        }

        // Вывод состояния и меню.
        public void DisplayStateMenu(Tamagotchi tamagotchi)
        {
            Console.WriteLine("\nHealth  " + _statePet[tamagotchi.Health]);
            Console.WriteLine("Hungry  " + _statePet[tamagotchi.Hungry]);
            Console.WriteLine("Fatigue " + _statePet[tamagotchi.Fatigue]);

            Console.WriteLine("\n\nWhat do you want to do?\n" +
                "1. Feed\n" +
                "2. Play\n" +
                "3. Dream\n" +
                "4. Treat \n" +
                "5. Exit\n\n" +
                "Enter number: ");
        }

        /// <summary>
        /// Просит ввести номер действия из меню.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void EnterActionNumber(Tamagotchi tamagotchi)
        {
            // Ввод номера действия.
            numberMenu = Console.ReadLine();

            switch (numberMenu)
            {
                case "1":
                    Feed(tamagotchi);
                    break;
                case "2":
                    Play(tamagotchi);
                    break;
                case "3":
                    Sleep(tamagotchi);
                    break;
                case "4":
                    Treat(tamagotchi);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nError!!!\nNo such item exists!\n");
                    EnterActionNumber(tamagotchi);
                    break;
            }
        }

        /// <summary>
        /// Покормить питомца.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void Feed(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Feed(tamagotchi);
            // Очистить консоль.
            Console.Clear();
            PrintInformationPet(tamagotchi);
        }

        /// <summary>
        /// Поиграть с питомцем.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void Play(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Play(tamagotchi);
            // Очистить консоль.
            Console.Clear();
            PrintInformationPet(tamagotchi);
        }

        /// <summary>
        /// Укачать питомца.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void Sleep(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Sleep(tamagotchi);
            // Очистить консоль.
            Console.Clear();
            PrintInformationPet(tamagotchi);
        }

        /// <summary>
        /// Лечить питомца.
        /// </summary>
        /// <param name="tamagotchi"></param>
        public void Treat(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Treat(tamagotchi);
            Console.Clear();
            PrintInformationPet(tamagotchi);
        }
    }
}
