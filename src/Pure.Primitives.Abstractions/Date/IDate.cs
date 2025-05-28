using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.Date;

public interface IDate
{
    public INumber<ushort> Day { get; }

    public INumber<ushort> Month { get; }

    public INumber<ushort> Year { get; }
}