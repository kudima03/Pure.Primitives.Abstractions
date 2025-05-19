namespace Pure.Primitives.Abstractions.Number;

public interface INumber<out T> where T : System.Numerics.INumber<T>
{
    internal T Value { get; }
}