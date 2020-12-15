# Project 1
## Description
This project aims to act as a store demo site with a working database.
## Technologies Used
* C#
* RESTful API
* HTML / CSS
* Visual Studio
* Microsoft Edge
* Postgre SQL
## Installation and use
Requires the use of an API viewer and Visual to run.
To Clone:
```Csharp
git clone https://github.com/201019-UiPath/MannJames-code.git
```
Once cloned, you will need to create an appsettings.json file to direct the application to any database.
Database tables can be created using EF Core Code-First approach using these commands:
```Csharp
dotnet ef migrations add initial -c StoreContext --startup-project ../StoreUI/StoreUI.csproj
dotnet ef database update --startup-project ../StoreUI/StoreUI.csproj
```
## Roadmap
* Make the website fully integrated to the API.
* Store payment information.
* Improve login validation.
* Clean up the code.
