using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.DayOfWeek;

public interface IDayOfWeek
{
    public INumber<ushort> DayNumberValue { get; }
}
