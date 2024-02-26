namespace Cars
{
    /// <summary>
    /// Тесла
    /// </summary>
    public class Tesla : ICar, IElecricCar
    {
        /// <summary>
        /// Модел
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Цвят
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Включване на двигателя
        /// </summary>
        public string Start()
        {
            return string.Format("Engine start");
        }

        /// <summary>
        /// Изключване на двигателя
        /// </summary>
        public string Stop()
        {
            return string.Format("Breaaak!");
        }

        /// <summary>
        /// Батерии
        /// </summary>
        public int Batteries { get; set; }

        /// <summary>
        /// Констуктор
        /// </summary>
        /// <param name="model">Модел</param>
        /// <param name="color">Цвят</param>
        /// <param name="batteries">Цвят</param>
        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Batteries = batteries;
        }

        public override string ToString()
        {
            return string.Format(
              "{0} Tesla {1} with {2} Batteries\n{3}\n{4} ",
              Color,
              Model,
              Batteries,
              Start(),
              Stop()
            );
        }
    }
}
