using System;

namespace TDDproject
{
    public class ArithmeticProgression : IArithmeticProgression
    {
        public double InitialElement { get; set; }
        public double Difference { get; set; }

        public ArithmeticProgression()
        {
            InitialElement = 0;
            Difference = 1;
        }

        public ArithmeticProgression(double initialElement, double difference)
        {
            InitialElement = initialElement;
            Difference = difference;
        }

        public double GetElement(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "The element number must be positive.");
            }
            return InitialElement + (n - 1) * Difference;
        }

        public double GetSum(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "The number of elements cannot be negative.");
            }
            if (n == 0)
            {
                return 0;
            }
            return (2 * InitialElement + (n - 1) * Difference) * n / 2.0;
        }

        public IArithmeticProgression Add(IArithmeticProgression other)
        {
            return new ArithmeticProgression(this.InitialElement + other.InitialElement, this.Difference + other.Difference);
        }

        public IArithmeticProgression Subtract(IArithmeticProgression other)
        {
            return new ArithmeticProgression(this.InitialElement - other.InitialElement, this.Difference - other.Difference);
        }

        public IArithmeticProgression Multiply(double number)
        {
            return new ArithmeticProgression(this.InitialElement * number, this.Difference * number);
        }

        public IArithmeticProgression Add(double number)
        {
            return new ArithmeticProgression(this.InitialElement + number, this.Difference);
        }

        public override string ToString()
        {
            return $"Progression: InitialElement = {InitialElement}, Difference = {Difference}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            ArithmeticProgression other = (ArithmeticProgression)obj;
            return (InitialElement == other.InitialElement) && (Difference == other.Difference);
        }

        public override int GetHashCode()
        {
            return InitialElement.GetHashCode() ^ Difference.GetHashCode();
        }
    }
}
