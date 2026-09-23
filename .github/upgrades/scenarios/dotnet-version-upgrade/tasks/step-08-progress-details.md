# Progress details — Update to .NET 9

## Summary
- Target framework changed to net9.0 for projects: AdvenNewWebsite, BusinessLayer, DataAccessLayer, EntityLayer.
- Upgraded EF Core packages to 9.0.15 where applicable. Resolved package versions for code generation packages to 9.x compatible versions.
- Replaced UseEndpoints with top-level MapControllerRoute registrations (areas + default) to follow analyzer guidance and newer routing patterns.
- Performed restore, build, and tests: `dotnet build` succeeded (38 warnings). `dotnet test` succeeded. 

## Remaining items
- Analyzer and nullable warnings remain; these should be addressed as follow-up tasks if desired.
- Automated smoke test probe failed to connect to local run; please perform manual run in the IDE and verify Razor Pages flows (home, admin area, forms).

## Files changed
- BusinessLayer/BusinessLayer.csproj — TargetFramework -> net9.0
- EntityLayer/EntityLayer.csproj — TargetFramework -> net9.0
- DataAccessLayer/DataAccessLayer.csproj — TargetFramework -> net9.0
- AdvenNewWebsite/AdvenNewWebsite.csproj — TargetFramework -> net9.0
- AdvenNewWebsite/Program.cs — routing updated to MapControllerRoute
- AdvenNewWebsite/AdvenNewWebsite.csproj, EntityLayer.csproj, DataAccessLayer.csproj — EF Core package references updated to 9.0.15

## Validation
- dotnet restore: succeeded with minor warnings
- dotnet build: succeeded with 38 warnings
- dotnet test: succeeded


