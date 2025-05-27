using System;

namespace Pure.Primitives.Abstractions.Date;

public interface IDate
{
    internal DateOnly DateValue { get; }
}