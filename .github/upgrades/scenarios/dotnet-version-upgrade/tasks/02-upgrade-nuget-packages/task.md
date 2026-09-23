# 02-upgrade-nuget-packages: Upgrade recommended NuGet packages

Upgrade NuGet packages flagged by the assessment (notably Microsoft.EntityFrameworkCore and related Design/Tools, plus any code-generation/design packages). Resolve the latest compatible versions for net9.0 per-project. Prefer stable releases.

**Done when**: PackageReference versions updated and `dotnet restore` succeeds for the solution.
