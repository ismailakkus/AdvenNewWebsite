# Progress details — Fix nullable warnings

## Summary
- Made model string and IFormFile properties nullable (e.g., `string?`, `IFormFile?`) for the Admin area models that were producing CS8618 warnings.
- Files modified:
  - AdvenNewWebsite/Areas/Admin/Models/HaberModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/ProjeModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/KullaniciModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/HizmetModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/BultenModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/ReferansModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/SliderModel.cs
  - AdvenNewWebsite/Areas/Admin/Models/SurecModel.cs

## Validation
- `dotnet build` completed successfully after changes (final build: 2 warnings remain unrelated to CS8618).

## Notes
- Choosing nullable (`string?`) is a conservative change; review whether some properties should instead be initialized to non-null defaults or marked `required`.
- Consider updating view code to handle null values where applicable.

