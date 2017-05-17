# .Net Core, Entity Framework Core and PostgreSQL

I used to be a .Net developer, nowmy primary job is frontend apps. I always loved how fast and convenient EF Code First is on a product prototype phase. For one of my pet project I decided to build backend server with the latest (May 2017) versions of .Net Core, EF Core and Postgres database.


In this article I will explane how to make EF Core work with Postgresqs database. At end of the lession we will hane a tiny web API application that can store basic user information and update database when model changes.


## Setting up the solution
The first step is to install required libraries for [.Net Core](https://www.microsoft.com/net/core). In VS Code you can just add C# extension and accept all the suggested installs.


Create solution directory and two new projects - Data and Web.
``` bash
    mkdir app
    cd app 
```

We are going to create new Web API project in folder `Web` and Data project in folde `Data` targeting the latest (as of 17.05.2017) .Net Core version.
``` bash
    dotnet new webapi -f netcoreapp1.1 -n Web -o Web
    dotnet new classlib -f netcoreapp1.1 -n Data -o Data
```

Now we are ready to create a solutin file and add our projects in the solution:
``` bash
    dotnet new sln -n App
    dotnet sln App.sln add Web/Web.csproj Data/Data.csproj
```

It is said that you can use patterns to specify project files to add (like this `dotnet sln App.sln add **/*.csproj`), but it just did not work for me.


To run the app we need to install all the packages first and then start the app. And yes, you need to `cd` into the startup project folder because pathes within the app (like `AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)` for example) are resolved related to the current directory.
``` bash
    dotnet restore
    cd Web
    dotnet run
```


If you open URL `http://localhost:5000/api/values` in browser you will see the application output.


## Entity Framework and PostgreSQL




ToDo
* register ef
* add dbcontext
* add model
* init default data
* configure code first
* reset db on model change
* connect controller with db
* showcase (get real user by API)