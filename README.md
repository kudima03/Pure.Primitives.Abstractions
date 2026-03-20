# Pure.Primitives.Abstractions

Base interfaces for the **Pure** ecosystem — immutable, composable abstractions over .NET primitive types.

[![.NET build & test](https://github.com/kudima03/Pure.Primitives.Abstractions/actions/workflows/build-and-check.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions/actions/workflows/build-and-check.yml)
[![Platforms compatibility check](https://github.com/kudima03/Pure.Primitives.Abstractions/actions/workflows/NativeAOT-compatibility.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions/actions/workflows/NativeAOT-compatibility.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Primitives.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Primitives.Abstractions)](https://www.nuget.org/packages/Pure.Primitives.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE.txt)

## Overview

`Pure.Primitives.Abstractions` defines a set of minimal, read-only interfaces that represent primitive values. Each interface exposes only a getter — no mutation, no side effects. Complex types are built by composing simpler ones.

## Interfaces

| Interface | Namespace | Description |
|-----------|-----------|-------------|
| `IBool` | `Pure.Primitives.Abstractions.Bool` | Boolean value |
| `IChar` | `Pure.Primitives.Abstractions.Char` | Single character |
| `IString` | `Pure.Primitives.Abstractions.String` | String value; implements `IEnumerable<IChar>` |
| `INumber<T>` | `Pure.Primitives.Abstractions.Number` | Generic numeric value; `T : INumber<T>` |
| `IDate` | `Pure.Primitives.Abstractions.Date` | Date (day, month, year via `INumber<ushort>`) |
| `ITime` | `Pure.Primitives.Abstractions.Time` | Time (hour, minute, second, millisecond, microsecond, nanosecond) |
| `IDateTime` | `Pure.Primitives.Abstractions.DateTime` | Composition of `IDate` and `ITime` |
| `IDayOfWeek` | `Pure.Primitives.Abstractions.DayOfWeek` | Day of week as a numeric value |
| `IGuid` | `Pure.Primitives.Abstractions.Guid` | GUID value |

## Design Principles

- **Immutable** — all interfaces expose only `get` properties; no setters, no methods that mutate state.
- **Composable** — complex types inherit from simpler ones (`IDateTime : IDate, ITime`; `IString : IEnumerable<IChar>`).
- **Generic** — `INumber<T>` is covariant (`out T`) and constrained to `System.Numerics.INumber<T>`, supporting any numeric type.
- **AOT-compatible** — the library is fully compatible with Native AOT compilation.

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```shell
dotnet add package Pure.Primitives.Abstractions
```

## Usage

Implement any interface to model an immutable primitive in your domain:

```csharp
using Pure.Primitives.Abstractions.Number;

public sealed class Age : INumber<ushort>
{
    public Age(ushort value) => NumberValue = value;
    public ushort NumberValue { get; }
}
```

Compose interfaces to build richer types:

```csharp
using Pure.Primitives.Abstractions.DateTime;

public sealed class BirthDateTime : IDateTime
{
    // implement IDate and ITime members
}
```
