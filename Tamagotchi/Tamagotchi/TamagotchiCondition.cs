using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        /// <param name="tamagotchi">Тамагочи</param>
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
        /// <param name="tamagotchi">Тамагочи</param>
        public void PrintPetInformation(Tamagotchi tamagotchi)
        {
            StartGame();

            if (tamagotchi.Name.Length == 0)
            {
                tamagotchi.Name = Console.ReadLine();

                while (tamagotchi.Name.Length == 0)
                {
                    PrintPetInformation(tamagotchi);
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

        /// <summary>
        /// Вывод типа питомца и предложения ввести имя.
        /// </summary>
        public void StartGame()
        {
            Console.Clear();
            // Вывод типа питомца.
            Console.WriteLine("###########################################################\n" +
               "############################ CAT ##########################\n" +
               "###########################################################\n\n");
            // Вывод сообщения с именем питомца.
            Console.WriteLine("Pet's name: ");
        }

        /// <summary>
        /// Вывод, что питомец болен.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void GetSick(Tamagotchi tamagotchi)
        {
            // Условие, что состояние здоровья равно 0.
            if (tamagotchi.Health == 0)
            {
                // Вывод сообщения, что питомец болен.
                Console.WriteLine("!!!The pet is sick!!!");
            }
        }

        /// <summary>
        /// Вывод состояния и меню.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
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
        /// <param name="tamagotchi">Тамагочи</param>
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
        /// <param name="tamagotchi">Тамагочи</param>
        public void Feed(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Feed(tamagotchi);
            Console.Clear();
            PrintPetInformation(tamagotchi);
        }

        /// <summary>
        /// Поиграть с питомцем.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Play(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Play(tamagotchi);
            Console.Clear();
            PrintPetInformation(tamagotchi);
        }

        /// <summary>
        /// Укачать питомца.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Sleep(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Sleep(tamagotchi);
            Console.Clear();
            PrintPetInformation(tamagotchi);
        }

        /// <summary>
        /// Лечить питомца.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Treat(Tamagotchi tamagotchi)
        {
            _tamagotchiActions.Treat(tamagotchi);
            Console.Clear();
            PrintPetInformation(tamagotchi);
        }
    }
}
