namespace BlackJack.Application.Entities
{
    public class Dealer : User
    {
        public Dealer(bool mainDealer)
        {
            IsMainDealer = mainDealer;
        }
        /// <summary>
        /// Счет до которого Дилеру обязательно, нужно брать карты
        /// </summary>
        public const int ScoreUpperBound = 17;
        /// <summary>
        /// Основной ли дилер за столом
        /// </summary>
        public bool IsMainDealer { get; private set; }
        /// <summary>
        /// Время сессии за столом
        /// </summary>
        public DateTime SessionTime { get; private set; }
        /// <summary>
        /// Другой дилер
        /// </summary>
        public Dealer AnotherDealer { get; private set; }
        /// <summary>
        /// Вытянуть карту
        /// </summary>
        /// <param name="card"></param>
        public override void PullCard(Card card)
        {
            if (Score <= ScoreUpperBound) 
            {
                base.PullCard(card);
            }
        }
        /// <summary>
        /// Поменяться с другим дилером
        /// </summary>
        /// <param name="anotherDealer">другой дилер</param>
        /// <returns></returns>
        public Dealer SwapWithAnotherDealer(Dealer anotherDealer)
        {
            AnotherDealer = anotherDealer;
            return AnotherDealer;
        }
        /// <summary>
        /// Установить время сессии
        /// </summary>
        /// <param name="time"></param>
        public virtual void SetSessionTime(DateTime time)
        {
            SessionTime = time;
        }
    }
}