namespace Pure.Primitives.Abstractions.Number;

public interface INumber<out T>
    where T : System.Numerics.INumber<T>
{
    public T NumberValue { get; }
}
