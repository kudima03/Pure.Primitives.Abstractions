# Changelog

All notable changes to Pure.Primitives.Abstractions are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [4.3.0] — 2025-11-13

### Changed

- Added `net10.0` as a target framework, alongside `net7.0`, `net8.0`, and `net9.0`.

## [4.2.0] — 2025-11-07

### Changed

- Package now multi-targets `net7.0`, `net8.0`, and `net9.0` (previously
  `net9.0` only).

## [4.1.0] — 2025-10-31

### Changed

- **Breaking:** Interface members that were `internal` are now `public`:
  `IBool.BoolValue`, `IChar.CharValue`, `IDayOfWeek.DayNumberValue`,
  `IGuid.GuidValue`, `INumber<T>.NumberValue`, `IString.TextValue`.
- Package now declares `IsAotCompatible` instead of separate
  `IsTrimmable` / `EnableTrimAnalyzer` / `EnableAotAnalyzer` properties.

## [4.0.11] — 2025-09-03

- Maintenance release: dependency and build updates.

## [4.0.10] — 2025-09-01

- Maintenance release: dependency and build updates.

## [4.0.9] — 2025-09-01

- Maintenance release: dependency and build updates.

## [4.0.8] — 2025-08-22

- Maintenance release: dependency and build updates.

## [4.0.7] — 2025-08-18

- Maintenance release: dependency and build updates.

## [4.0.6] — 2025-06-19

- Maintenance release: dependency and build updates.

## [4.0.5] — 2025-06-17

- Maintenance release: dependency and build updates.

## [4.0.4] — 2025-06-13

- Maintenance release: dependency and build updates.

## [4.0.3] — 2025-06-12

- Maintenance release: dependency and build updates.

## [4.0.2] — 2025-06-10

- Maintenance release: dependency and build updates.

## [4.0.1] — 2025-06-02

### Changed

- **Breaking:** `ITime.Nanoseconds` renamed to `ITime.Nanosecond`.

## [4.0.0] — 2025-05-31

### Added

- `ITime.Nanoseconds` component, giving `ITime` nanosecond precision.

### Changed

- **Breaking:** `IDayOfWeek.DayNumberValue` type changed from
  `INumber<int>` to `INumber<ushort>`.

## [3.0.1] — 2025-05-29

- Maintenance release: dependency and build updates.

## [3.0.0] — 2025-05-28

### Changed

- **Breaking:** `IDate` redesigned from a single `DateValue` property to
  `Day`, `Month`, and `Year` components, each `INumber<ushort>`.
- **Breaking:** `ITime` redesigned from a single `TimeValue` property to
  `Hour`, `Minute`, `Second`, `Millisecond`, and `Microsecond` components,
  each `INumber<ushort>`.

## [2.0.0] — 2025-05-27

### Added

- `IDate` interface, wrapping a `DateOnly` value.
- `ITime` interface, wrapping a `TimeOnly` value.
- `IDateTime` interface, combining `IDate` and `ITime`.

### Changed

- **Breaking:** `IBool.Value` renamed to `BoolValue`.
- **Breaking:** `IChar.Value` renamed to `CharValue`.
- **Breaking:** `IString.Value` renamed to `TextValue`.
- **Breaking:** `INumber<T>.Value` renamed to `NumberValue`.
- **Breaking:** `IGuid.Value` renamed to `GuidValue`.
- **Breaking:** `IDayOfWeek.DayNumber` renamed to `DayNumberValue`.

## [1.0.0] — 2025-05-26

### Changed

- `IString` now implements `IEnumerable<IChar>`.

## [0.1.5] — 2025-05-25

- Maintenance release: dependency and build updates.

## [0.1.4] — 2025-05-24

- Maintenance release: dependency and build updates.

## [0.1.3] — 2025-05-23

- Maintenance release: dependency and build updates.

## [0.1.2] — 2025-05-23

- Maintenance release: dependency and build updates.

## [0.1.1] — 2025-05-21

- Maintenance release: dependency and build updates.

## [0.1.0] — 2025-05-21

### Added

- Initial release with primitive abstraction interfaces: `IBool`, `IChar`,
  `IDayOfWeek`, `IGuid`, `INumber<T>`, and `IString`.
