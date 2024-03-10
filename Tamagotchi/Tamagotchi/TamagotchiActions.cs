using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    /// <summary>
    /// Класс действий.
    /// </summary>
    internal class TamagotchiActions : ITamagotchiActions
    {
        /// <summary>
        /// Покормить питомца.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Feed(Tamagotchi tamagotchi)
        {
            tamagotchi.Hungry = tamagotchi.Hungry - 2;
        }

        /// <summary>
        /// Поиграть с питомцем.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Play(Tamagotchi tamagotchi)
        {
            tamagotchi.Fatigue = tamagotchi.Fatigue + 1;
        }

        /// <summary>
        /// Укачать питомца. 
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Sleep(Tamagotchi tamagotchi)
        {
            tamagotchi.Fatigue = 0;
            tamagotchi.Health = tamagotchi.Health + 1;
            tamagotchi.Hungry = tamagotchi.Hungry + 1;
        }

        /// <summary>
        /// Увеличение состояний голода и усталости.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void IncreaseState(Tamagotchi tamagotchi)
        {
            tamagotchi.Fatigue = tamagotchi.Fatigue + 1;
            tamagotchi.Hungry = tamagotchi.Hungry + 1;
        }

        /// <summary>
        /// Увеличение состояний здоровья.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        public void Treat(Tamagotchi tamagotchi)
        {
            tamagotchi.Health = 10;
        }
    }
}
