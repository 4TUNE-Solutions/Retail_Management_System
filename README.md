# Retail_Management_System

- **For Database related things use  `DB_` prefix!**
- **For Store Interface related things use `SI_` prefix!**
- **For Inventory Interface related things use `INI_` prefix!**
- **For API related things use `API_` prefix!**
# Branches
`main` is production branch, `development` is general probe branch, feel free to create appropriate branches for pull requests

## Branch naming (IMPORTANT)
`<author>_<branch-type>_<branch-name>`, where branch-type is either feature, enhancement, bug (refer to issue label). branch name - refer to issue name, or feature request

e.g. - `john_new_feature_API_sales_tax_endpoint`. Use `_` delimiter.

# Pull Requests
**Every pr must be reviewed ONCE before merging with `development` branch, and TWICE in merging with `main` branch.**

# Commit messages
```
Summary:
<issue-ID> <commit-type> <verb in imperative> <rest of message (max 80 char)>
     ^
     |
include if applicable

Description:
<Free text, describe more if necessary> (optional, about 72 char)

Commit types:

feat: The new feature you're adding to a particular application
fix: A bug fix
style: Feature and updates related to styling
refactor: Refactoring a specific section of the codebase
test: Everything related to testing
docs: Everything related to documentation
chore: Regular code maintenance.[You can also use emojis to represent commit types]

Write your commit message in the imperative: "Fix bug" and not "Fixed bug"
or "Fixes bug".
```

# RMSData

*Keep in mind that some folders may be missing, because they are empty, and git does not show them. Also, there may be a placeholder file in order to show folder on github.*

Database project.
- dbo ('database owner'. Database schema.)
  - Tables
  - Views
  - Stored Procedures

# R_M_S_API.Library

*Class library for communicating with database.*


API Class Library Project
- Internal
  - DataAccess 
    - Methods for communicating with database
- Data Access
  - Calling methods from DataAccess
- Models
  - Data Objects for storing information about specific table

# R_M_S_API

*Web API for connecting database with system*

ASP.NET WebAPI Project
- Controllers
  - Different groups specialized for certain logic within database and system communication

# MvxR_M_S.Wpf

*WPF UI containing only views, or UI part of system*

WPF Project
- Views
  - XAML designed UI for Windows7 +

# MvxR_M_S.Core

*Core logic of application. Applicable over different UIs. Uses MVVM pattern*

WPF Class Library project
- API
  - Classes for talking to API
- Models
  - Data Objects used for storing data within database and system communication
- Validators
  - Data validation through system logic
- ViewModels
  - Classes responsible for all business code and logic

# NuGet packages used:
- MvvmCross
- FluentValidation
- Newtonsoft.Json
- Swashbuckle
- Dapper

