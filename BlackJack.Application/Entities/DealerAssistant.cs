namespace BlackJack.Application.Entities
{
    public class DealerAssistant : Dealer
    {
        public DealerAssistant(bool mainDealer) 
            :base(mainDealer)
        {

        }
        /// <summary>
        /// Ассистент может быть дилером 4 часа
        /// </summary>
        public DateTime AssistentSessionTime = new DateTime(0, 0, 0, 4, 0, 0);
        /// <summary>
        /// Количетсво раздач ассистена
        /// </summary>
        public int NumberOfHands { get; private set; }
        /// <summary>
        /// Установить время сессии Ассистента
        /// </summary>
        /// <param name="time"></param>
        public override void SetSessionTime(DateTime time)
        {
            if(time > AssistentSessionTime)
            {
                SwapWithAnotherDealer(AnotherDealer);
            }
            base.SetSessionTime(time);
        }
        /// <summary>
        /// Позвать основного дилера
        /// </summary>
        /// <param name="dealer"></param>
        /// <returns></returns>
        public Dealer CallMainDealer(Dealer dealer)
        {
            if (IsMainDealer)
                return dealer;

            return SwapWithAnotherDealer(AnotherDealer);
        }

        public void SetNumberOfHands(int numberOfHands)
        {
            NumberOfHands = numberOfHands;
        }
    }
}
