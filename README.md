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

*Keep in mind that some folders may be missing, because they are empty, and git does not show them. Also, there may be a placeholder file in order to show folder on gh.*

Database project.
- dbo ('database owner'. Database schema.)
  - Tables
  - Views
  - Stored Procedures
