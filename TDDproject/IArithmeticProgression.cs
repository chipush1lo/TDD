using System;

namespace TDDproject
{
    public interface IArithmeticProgression
    {
        double InitialElement { get; set; }
        double Difference { get; set; }

        double GetElement(int n);
        double GetSum(int n);
        IArithmeticProgression Add(IArithmeticProgression other);
        IArithmeticProgression Subtract(IArithmeticProgression other);
        IArithmeticProgression Multiply(double number);
        IArithmeticProgression Add(double number);
    }
}
