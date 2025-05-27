using System;

namespace Pure.Primitives.Abstractions.Time;

public interface ITime
{
    internal TimeOnly TimeValue { get; }
}