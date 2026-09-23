# Upgrade AdvenNewWebsite to .NET 9

## Overview

**Target**: Upgrade AdvenNewWebsite solution from .NET 6 to .NET 9 (net9.0).
**Scope**: 4 projects (AdvenNewWebsite, BusinessLayer, DataAccessLayer, EntityLayer). Changes are small and limited to project files and a handful of package updates and code fixes flagged in the assessment.

## Tasks

### 01-update-project-tfms: Update project TargetFrameworks to net9.0

Change the `<TargetFramework>` element from `net6.0` to `net9.0` in each project file: AdvenNewWebsite, BusinessLayer, DataAccessLayer, EntityLayer. This prepares projects to restore and resolve package compatibility for the new TFM.

**Done when**: Each project file contains `<TargetFramework>net9.0</TargetFramework>` and all projects load in the IDE without XML/MSBuild errors.

---

### 02-upgrade-nuget-packages: Upgrade recommended NuGet packages

Upgrade NuGet packages flagged by the assessment (notably Microsoft.EntityFrameworkCore and related Design/Tools, plus any code-generation/design packages). Resolve the latest compatible versions for net9.0 per-project. Prefer stable releases.

**Done when**: PackageReference versions updated and `dotnet restore` succeeds for the solution.

---

### 03-restore-and-build: Restore packages and build solution

Run `dotnet restore` and `dotnet build` for the solution. Fix compilation errors introduced by the TFM or package updates. Iterate until the build succeeds.

**Done when**: `dotnet build` completes successfully with zero errors.

---

### 04-fix-api-behavioral-issues: Address behavioral and API changes

Address the UseExceptionHandler behavioral change flagged in the assessment and any source-level issues reported by the compiler or elevated by package updates. For Razor Pages, verify Program.cs or Startup.cs pipeline changes and update middleware as needed.

**Done when**: Identified behavioral issues are addressed and verified by unit tests or manual checks.

---

### 05-test-and-smoke-verify: Run tests and smoke test the Razor Pages app

Run unit and integration tests (if any). Launch the app locally and manually exercise key Razor Pages flows (home page, login, key user journeys) to confirm runtime behavior.

**Done when**: Tests pass and the app loads and renders key pages without runtime exceptions.

---

### 06-finalize-documentation: Update instructions and produce progress notes

Update `scenario-instructions.md` (already updated to net9.0), add a short note in README or changelog about the new TFM, and write a `progress-details.md` summarizing changes and validation results.

**Done when**: Documentation files are written and the scenario artifacts contain the progress-details.md entry.

---

### 07-cleanup-and-verify: Final checks

Run a final `dotnet build` and `dotnet test` to ensure nothing regressed. Confirm there are no remaining package compatibility warnings and that the solution opens cleanly in Visual Studio.

**Done when**: Final build and test pass; assessment artifact updated with any remaining issues.
---

### 08-fix-nullable-warnings: Fix CS8618 nullable initialization warnings

Make model properties that cause CS8618 warnings nullable where appropriate (e.g., change `string` to `string?` or `IFormFile` to `IFormFile?`), or add safe default initializers when semantics require non-null values. Focus on Areas/Admin models reported by the build.

**Done when**: `dotnet build` completes with zero CS8618 warnings (or acceptable intentional exceptions documented).
