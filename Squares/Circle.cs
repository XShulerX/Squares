using System;

namespace Squares
{
    public sealed class Circle : Figure
    {
        public double Radius;

        /// <summary>
        /// Создание круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус не может быть меньше или равен 0");
            Radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
