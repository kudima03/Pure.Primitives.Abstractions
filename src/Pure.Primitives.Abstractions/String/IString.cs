using Pure.Primitives.Abstractions.Char;
using System.Collections.Generic;

namespace Pure.Primitives.Abstractions.String;

public interface IString : IEnumerable<IChar>
{
    internal string Value { get; }
}