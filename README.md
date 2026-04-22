# Phalanx CI Fixer v2 — C# Testbed

Controlled failures in C# so the v2 agent can diagnose, fix, and close PRs end-to-end. Mirror of the Python / TS / JS / Java testbeds but for the C# scorecard row.

- 5 languages × 4 failure classes = 20 scorecard cells. This repo covers the 4 C# cells.
- Each `failures/*.patch` introduces one class of CI failure when applied to `main`.
- CI runs `dotnet format` (Lint job) and `dotnet test` with Coverlet 80% line gate (Test + Coverage job).

## Intentional failure patches

| Patch                     | Cell      | What it breaks                                                         |
| ------------------------- | --------- | ---------------------------------------------------------------------- |
| `01-lint.patch`           | lint      | `dotnet format --verify-no-changes` violation in `MathOps.cs`          |
| `02-test-assertion.patch` | test_fail | `Multiply` returns `a + b` instead of `a * b`                          |
| `03-flake-sleep.patch`    | flake     | `Thread.Sleep(Random.Shared.Next(3000))` inside an xUnit 2s timeout    |
| `04-coverage-drop.patch`  | coverage  | Adds two untested helpers → Coverlet line coverage under 80%           |

## Running locally

```bash
dotnet format --verify-no-changes   # lint
dotnet test                          # tests + Coverlet coverage gate
```

.NET 8 SDK required.
