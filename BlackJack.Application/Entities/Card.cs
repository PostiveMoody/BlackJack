using BlackJack.Application.Enums;

namespace BlackJack.Application.Entities
{
    public class Card
    {
        /// <summary>
        /// Значения карты
        /// </summary>
        public int ValueAt { get; private set; }
        /// <summary>
        /// Масть карты
        /// </summary>
        public CardSuit CardSuit { get; private set; }
        /// <summary>
        /// Признак что карта, является тузом
        /// </summary>
        public bool IsAce { get; private set; }

        /// <summary>
        /// Создать карту
        /// </summary>
        /// <param name="value">Значимость карты</param>
        /// <param name="cardSuit">Масть карты</param>
        /// <param name="isAce">Это туз?</param>
        /// <returns></returns>
        public static Card Create(int value, CardSuit cardSuit, bool isAce = false)
        {
            return new Card
            {
                ValueAt = value,
                CardSuit = cardSuit,
                IsAce = isAce
            };
        }
    }
}
