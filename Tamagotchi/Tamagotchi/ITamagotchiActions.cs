
namespace Tamagotchi
{
    /// <summary>
    /// Интерфейс ITamagotchiActions.
    /// </summary>
    internal interface ITamagotchiActions
    {
        /// <summary>
        /// Покормить питомца
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        void Feed(Tamagotchi tamagotchi);

        /// <summary>
        /// Усыпить питомца.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        void Sleep(Tamagotchi tamagotchi);

        /// <summary>
        /// Поиграть с питомцем.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        void Play(Tamagotchi tamagotchi);

        /// <summary>
        /// Полечить с питомцем.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        void Treat(Tamagotchi tamagotchi);

        /// <summary>
        /// Увеличение состояний.
        /// </summary>
        /// <param name="tamagotchi">Тамагочи</param>
        void IncreaseState(Tamagotchi tamagotchi);
    }
}
