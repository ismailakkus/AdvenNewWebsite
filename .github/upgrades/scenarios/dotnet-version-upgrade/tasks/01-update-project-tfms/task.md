# 01-update-project-tfms: Update project TargetFrameworks to net9.0

Change the `<TargetFramework>` element from `net6.0` to `net9.0` in each project file: AdvenNewWebsite, BusinessLayer, DataAccessLayer, EntityLayer. This prepares projects to restore and resolve package compatibility for the new TFM.

**Done when**: Each project file contains `<TargetFramework>net9.0</TargetFramework>` and all projects load in the IDE without XML/MSBuild errors.
