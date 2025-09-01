using System.Collections.Generic;
using Pure.Primitives.Abstractions.Char;

namespace Pure.Primitives.Abstractions.String;

public interface IString : IEnumerable<IChar>
{
    internal string TextValue { get; }
}
