namespace BlackJack.Application.Entities
{
    public class User
    {
        /// <summary>
        /// Счет
        /// </summary>
        public int Score { get; private set; }
        /// <summary>
        /// Карты
        /// </summary>
        public List<Card> Cards { get; private set; }

        /// <summary>
        /// Вытянуть карту
        /// </summary>
        public virtual void PullCard(Card card)
        {
            Cards.Add(card);
            Score += card.ValueAt;
        }
        /// <summary>
        /// Пропустить, пассануть
        /// </summary>
        public void Pass()
        {

        }
    }
}