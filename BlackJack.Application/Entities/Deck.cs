using BlackJack.Application.Enums;

namespace BlackJack.Application.Entities
{
    /// <summary>
    /// Колода карт
    /// </summary>
    public class Deck
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
        /// Карты этой колоды
        /// </summary>
        private Card[] Cards = new Card[QuantityCardInDeck];

        public Deck()
        {
            FillDeck();
        }

        /// <summary>
        /// Заполнить колоду картами
        /// </summary>
        private void FillDeck()
        {
            GetCardsNumbers();
            GetCardsPictures();
        }
        /// <summary>
        /// Получить карты-цифры
        /// </summary>
        /// <returns></returns>
        private void GetCardsNumbers()
        {
            for (int i = 0; i < CardTypes - CardTypesPictures; i++)
            {
                int cardSuitIterator = 0;
                for (int j = SameSuit - 4; j < SameSuit; j++)
                {
                    Cards[j] = Card.Create((int)CardValues.Two + i, CardSuit.Clubs + cardSuitIterator);
                    cardSuitIterator++;
                }
                SameSuit += 4;
            }
        }
        /// <summary>
        /// Получить карты картинки
        /// </summary>
        private void GetCardsPictures()
        {
            int cardSuitIterator = 0;
            for (int i = SameSuit - 4; i < SameSuit; i++)
            {
                Cards[i] = Card.Create((int)CardValues.Ten, CardSuit.Clubs + cardSuitIterator);
                cardSuitIterator++;
            }

            cardSuitIterator = 0;
            SameSuit += 4;
            for (int i = SameSuit - 4; i < SameSuit; i++)
            {
                Cards[i] = Card.Create((int)CardValues.Jack, CardSuit.Clubs + cardSuitIterator);
                cardSuitIterator++;
            }

            cardSuitIterator = 0;
            SameSuit += 4;
            for (int i = SameSuit - 4; i < SameSuit; i++)
            {
                Cards[i] = Card.Create((int)CardValues.Queen, CardSuit.Clubs + cardSuitIterator);
                cardSuitIterator++;
            }

            cardSuitIterator = 0;
            SameSuit += 4;
            for (int i = SameSuit - 4; i < SameSuit; i++)
            {
                Cards[i] = Card.Create((int)CardValues.King, CardSuit.Clubs + cardSuitIterator);
                cardSuitIterator++;
            }

            cardSuitIterator = 0;
            SameSuit += 4;
            for (int i = SameSuit - 4; i < SameSuit; i++)
            {
                Cards[i] = Card.Create((int)CardValues.Ace, CardSuit.Clubs + cardSuitIterator);
                cardSuitIterator++;
            }
        }
    }
}
