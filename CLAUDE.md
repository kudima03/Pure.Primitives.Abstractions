# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore                                # restore dependencies
dotnet build --no-restore -warnaserror        # build (treats warnings as errors)
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format && csharpier format .           # auto-fix code style
dotnet pack --configuration Release -p:PackageVersion=<version> --output .  # pack NuGet
```

There are no test projects in this repository — the CI pipeline only builds and checks formatting.

## Architecture

This is a **interfaces-only NuGet library** — no implementations, no tests, no dependencies. Every file defines exactly one interface.

**Composition hierarchy:**

- `INumber<out T>` (covariant, `T : System.Numerics.INumber<T>`) — the base numeric building block
- `IDate` — `Day`, `Month`, `Year` as `INumber<ushort>`
- `ITime` — `Hour`, `Minute`, `Second`, `Millisecond`, `Microsecond`, `Nanosecond` as `INumber<ushort>`
- `IDateTime : IDate, ITime` — pure composition, no new members
- `IString : IEnumerable<IChar>` — also exposes `TextValue` as raw `string`
- `IDayOfWeek` — wraps a numeric value
- `IBool`, `IChar`, `IGuid` — thin wrappers over their corresponding BCL types

Each interface lives in its own subfolder matching its namespace (`Pure.Primitives.Abstractions.<FolderName>`).

**Multi-targeting:** `net7.0`, `net8.0`, `net9.0`, `net10.0`. All interfaces must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 4.3.0`. Any API-breaking change (removing a member, changing a type) will fail the build. New interfaces or members on existing interfaces must be additive.

**Publishing:** triggered automatically by pushing a semver tag (e.g., `git tag 4.4.0 && git push origin 4.4.0`). The tag becomes the `PackageVersion`. Publishes to both GitHub Packages and NuGet.

## Code Style

Enforced via `.editorconfig` and `dotnet format --verify-no-changes` in CI:

- No `var` — always use explicit types
- Expression-bodied members for properties, indexers, accessors, and lambdas; **not** for methods or constructors
- File-scoped namespaces (`namespace Foo;`)
- `using` directives outside the namespace
- Max line length: 90 characters
- `System.*` usings first, no blank lines between using groups
- Namespace must match folder structure
- Private fields: `_camelCase`; interfaces: `I`-prefixed PascalCase; generic type parameters: `T`-prefixed PascalCase

## Commit Messages

Do not mention Claude or AI assistance in commit messages.