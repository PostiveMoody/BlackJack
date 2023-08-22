using BlackJack.Application.Entities;
using BlackJack.Application.Enums;

namespace BlackJack.Application.Application
{
    public class Game
    {
        /// <summary>
        /// Количество карт в колоде
        /// </summary>
        public const int QuantityCardInDeck = 52;
        /// <summary>
        /// Количество карт-цифр в колоде
        /// </summary>
        public const int QuantityCardInDeckNumbers = 32;
        /// <summary>
        /// Количесто типов карт CardTypes * SameSuit = 52
        /// </summary>
        public const int CardTypes = 13;
        /// <summary>
        /// Количество карт-картинок в колоде
        /// </summary>
        public const int CardTypesPictures = 5;
        /// <summary>
        /// Карт одной масти
        /// </summary>
        public int SameSuit = 4;

        /// <summary>
        /// Старт игры
        /// </summary>
        public void Start()
        {
           Deck deck = new Deck();
        }
    }
}