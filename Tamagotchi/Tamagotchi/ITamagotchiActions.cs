
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
        /// <param name="tamagotchi"></param>
        void Feed(Tamagotchi tamagotchi);
    
        /// <summary>
        /// Усыпить питомца.
        /// </summary>
        /// <param name="tamagotchi"></param>
        void Sleep(Tamagotchi tamagotchi);
    
        /// <summary>
        /// Поиграть с питомцем.
        /// </summary>
        /// <param name="tamagotchi"></param>
        void Play(Tamagotchi tamagotchi);
    
        /// <summary>
        /// Полечить с питомцем.
        /// </summary>
        /// <param name="tamagotchi"></param>
        void Treat(Tamagotchi tamagotchi);
    
        /// <summary>
        /// Увеличение состояний.
        /// </summary>
        /// <param name="tamagotchi"></param>
        void IncreaseState(Tamagotchi tamagotchi);
    }
}
