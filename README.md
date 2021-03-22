# dotnet-with-react
This is an end to end application in react and dotnet, all using open source libraries and technologies.

# Technologies
- Frontend
    - React & Redux (Application created using typescript template).
- Backend
    - DotNet Core Web API (.Net 5.0) (With support for multiple database vendors).
    - Supports Swagger Open API.
    - Currently supporting (Microsoft SQL Server & Postgres SQL).
- Tooling
    - This project uses all the open source technologies and the preferred IDE is [VS Code](https://code.visualstudio.com/download).

# Folder Structure
- Contains two seperate folder for client and server.
- client folder contains all the typescript code for react.
- server folder contains all the c# code for web api.
- There are other helper class libraries projects for Server.
    - DataAccess - Contains SQLServerDbContext as well Postgres DbContext both derived from AppDbContext.
    - Entities - Contains all Models which are shared by different class libraries. It can also contain Constant and Enums.
    - Dtos - Contains Dtos to be used by WebApi layer.
    - Services - It is the service layer, which will take the context and perform db operations.
    - DataAccess\PostgresMigrations - Contains Migrations for Postgres Database.
    - DataAccess\SQLServerMigrations - Contains Migrations for SQL Server Database.

# Setting Up Frontend
##### Download the latest stable version of NodeJS (v14.6.0 LTS)
[Download NodeJS](https://nodejs.org/en/)

##### Install all the client side dependencies
Navigate to client folder and run this command.
`npm install`

##### Start the frontend
`npm start` and frontend will be up and running in http://localhost:3000

# Setting Up Backend
##### Download the latest stable version of .Net (v5.0.4 )
[Download .Net](https://dotnet.microsoft.com/download/dotnet/5.0)

##### Install all the server side dependencies
Navigate to server folder and run this command.
`dotnet restore`

##### Check if there are any build errors
`dotnet build`

##### Start the backend
`dotnet run` and backend will be up and running in http://localhost:5000 or https://localhost:5001
Navigate to https://localhost:5001/swagger to open Swagger UI.


# Setting Up Entity Framework
##### Install the Entity Framework CLI
`dotnet tool install --global dotnet-ef`

##### To Add the Migrations (SQL Server and Postgres)
Navigate to Server folder and run this command.   

`dotnet ef  migrations add InitialCreate --startup-project ../Server/ --project ../DataAccess/ --context SQLServerDbContext --output-dir SqlServerMigrations --json`

`dotnet ef  migrations add InitialCreate --startup-project ../Server/ --project ../DataAccess/ --context PostgresDbContext --output-dir PostgresMigrations --json`


##### To Update the Database with Migrations

`dotnet ef database update --startup-project ../Server/ --project ../DataAccess/ --context SQLServerDbContext`

`dotnet ef database update --startup-project ../Server/ --project ../DataAccess/ --context PostgresDbContext`

# Setting Up Connection Strings for Databases
The appSettings.Development.json and appsettings.json file will contain the connection strings for database.
It will be in this format.
"DatabaseType" - contains info for which database you are using. It can be plain string based on your DB type.
"ConnectionStrings: - contains the connection string for the respective databases.
For security reasons, it is not checked in.
```
"DatabaseType": "MSSQLServer",
  "ConnectionStrings": {
    "SQLServerConnectionString": "Server=SERVERNAME\\SQLEXPRESS;Database=HospitalDB;User Id=sa;Password=yourpassword",
    "PostgresConnectionString": "host=localhost;port=5432;database=HospitalDB;user id=postgres;password=yourpassword"
  }
```
# Adding the Secret for creating Password Hash
Add this key in appSettings.Development.json and appSettings.json For security resons, don't ever check in your secret key.
```
"AppSettings": {
  "Secret": "Don't add your secret!"
}
```

