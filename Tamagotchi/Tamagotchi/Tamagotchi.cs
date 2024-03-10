using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    /// <summary>
    /// Класс тамагочи.
    /// </summary>
    public class Tamagotchi
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name = "";

        /// <summary>
        /// Здоровье.
        /// </summary>
        private int _health = 10;

        /// <summary>
        /// Голод.
        /// </summary>
        private int _hungry = 0;

        /// <summary>
        /// Усталость.
        /// </summary>
        private int _fatigue = 0;

        /// <summary>
        /// Возвращает и задает имя. 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает здоровье. 
        /// </summary>
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value > 10)
                {
                    value = 10;
                }

                if (value < 0)
                {
                    // Очищение консоли.
                    Console.Clear();
                    // Вывод сообщения, что игра окончена.
                    Console.WriteLine("#######################################################\n" +
                        "####################### GAME OVER #####################\n" +
                        "########################################################\n");
                    // Ожидание нажатия на клавишу.
                    Console.ReadKey();
                    // Выход из консоли.
                    Environment.Exit(0);
                }
                _health = value;
            }
        }

        /// <summary>
        /// Возвращает и задает голод. 
        /// </summary>
        public int Hungry
        {
            get
            {
                return _hungry;
            }
            set
            {
                if (value > 10)
                {
                    value = 10;
                }
                if (value < 0)
                {
                    Health = Health - 1;
                    value = 0;
                }
                _hungry = value;
            }
        }

        /// <summary>
        /// Возвращает и задает усталость. 
        /// </summary>
        public int Fatigue
        {
            get
            {
                return _fatigue;
            }
            set
            {
                if (value > 10)
                {
                    Health = Health - 1;
                    Hungry = Hungry + 1;
                    value = 10;
                }
                if (value < 0)
                {
                    value = 0;
                }
                _fatigue = value;
            }
        }
    }
}
