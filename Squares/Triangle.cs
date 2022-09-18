using System;

namespace Squares
{
    public sealed class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        private bool _isStraight;
        private double _hypotenuse;
        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Одна или несколько сторон меньше или равны 0");

            double ab = a + b;
            double ac = a + c;
            double bc = b + c;

            if (ab < c || ac < b || bc < a)
                throw new ArgumentException("Треугольник с заданными сторонами не может существовать");

            _a = a;
            _b = b;
            _c = c;

            checkingForStraight(a,b,c);
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            double S = 0;
            if (_isStraight)
            {
                double firstCathet;
                double secondCathet;
                if (_a == _hypotenuse)
                {
                    firstCathet = _b;
                    secondCathet = _c;
                }
                else if(_b == _hypotenuse)
                {
                    firstCathet = _a;
                    secondCathet = _c;
                }
                else
                {
                    firstCathet = _a;
                    secondCathet = _b;
                }
                S = 0.5 * firstCathet * secondCathet;
                return S;
            }
            else
            {
                double p = (_a + _b + _c)/2;
                S = Math.Sqrt((p*(p-_a)*(p-_b)*(p-_c)));
                return S;
            }
        }



        /// <summary>
        /// Проверка на прямоугольный треугольник
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        private void checkingForStraight(double a, double b, double c)
        {
            double hypotenuse;
            double firstCathet;
            double secondCathet;

            if (a > b)
            {
                firstCathet = b;
                if (a > c)
                {
                    hypotenuse = a;
                    secondCathet = c;
                }
                else
                {
                    hypotenuse = c;
                    secondCathet = b;
                }
            }
            else
            {
                firstCathet = a;
                if(b > c)
                {
                    hypotenuse = b;
                    secondCathet = c;
                }
                else
                {
                    hypotenuse = c;
                    secondCathet = b;
                }
            }

            _hypotenuse = hypotenuse;
            if (Math.Pow(hypotenuse, 2) == Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2))
                _isStraight = true;
            else
                _isStraight = false;
        }
    }
}
