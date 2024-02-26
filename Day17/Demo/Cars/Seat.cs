namespace Cars
{
    /// <summary>
    /// Сият
    /// </summary>
    public class Seat : ICar
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
        /// Констуктор
        /// </summary>
        /// <param name="model">Модел</param>
        /// <param name="color">Цвят</param>
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return string.Format(
              "{0} Seat {1}\n{2}\n{3}", 
              Color, 
              Model,
              Start(),
              Stop()
            );
        }
    }
}
