using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.Time;

public interface ITime
{
    public INumber<ushort> Hour { get; }

    public INumber<ushort> Minute { get; }

    public INumber<ushort> Second { get; }

    public INumber<ushort> Millisecond { get; }

    public INumber<ushort> Microsecond { get; }
}