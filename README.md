# TimeTrackerApi

## Setup

Since the app uses a Microsoft SQL Server database you should have a [MSSQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) instance and [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15) installed on your machine.

When both is installed you can follow these steps:

```
$ git clone https://github.com/SimonEhleringer/TimeTrackerApi.git
```
- [Restore the database](https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/restore-a-database-backup-using-ssms?view=sql-server-ver15) with the dump included in this repository (`./__DatabaseDump/TimeTracker.bak`).
- Change the server in the connection string in the appsettings.json file (`./TimeTrackerApi.Api/appsettings.json` -> "ConnectionStrings" -> "TimeTracker") to the server running on your machine. Normally the rest of the connection string does not need to be adjusted.
```
$ cd ./TimeTrackerApi/TimeTrackerApi.Api
$ dotnet run
```
