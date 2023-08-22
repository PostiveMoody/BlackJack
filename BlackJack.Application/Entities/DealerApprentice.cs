namespace BlackJack.Application.Entities
{
    public class DealerApprentice : Dealer
    {
        public DealerApprentice(bool mainDealer)
            :base(mainDealer)
        {
            
        }
        /// <summary>
        /// Ученик дилера может быть дилером 2 часа
        /// </summary>
        public DateTime ApprenticeSessionTime = new DateTime(0, 0, 0, 2, 0, 0);
        public List<string> QuestionsForDealer { get; private set; }
        public int CountOfMistakes { get; private set; }

        /// <summary>
        /// Установить время сессии Ученика
        /// </summary>
        /// <param name="time">Время</param>
        public override void SetSessionTime(DateTime time)
        {
            if (time > ApprenticeSessionTime)
            {
                SwapWithAnotherDealer(AnotherDealer);
            }
            base.SetSessionTime(time);
        }
        /// <summary>
        /// Задать вопрос дилеру
        /// </summary>
        /// <param name="question">Вопрос</param>
        public void SetQuestionForDealer(string question)
        {
            QuestionsForDealer.Add(question);
        }
        /// <summary>
        /// Неправильная раздача
        /// </summary>
        public void IncorrectDistribution()
        {
            CountOfMistakes++;
        }
    }
}
