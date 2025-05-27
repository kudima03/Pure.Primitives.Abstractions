using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.DayOfWeek;

public interface IDayOfWeek
{
    internal INumber<int> DayNumberValue { get; }
}