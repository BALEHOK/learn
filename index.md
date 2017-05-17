# .Net Core, Entity Framework Core and Postgresql


I used to be a .Net developer, nowmy primary job is frontend apps. I always loved how fast and convenient EF Code First is on a product prototype phase. For one of my pet project I decided to build backend server with the latest (May 2017) versions of .Net Core, EF Core and Postgres database.


In this article I will explane how to make EF Core work with Postgresqs database. At end of the lession we will hane a tiny web API application that can store basic user information and update database when model changes.


The first step is to install required libraries for .Net Core **[give link to setup guide]** In VS Code you can just install C# extension and accepts all his suggestions.


Create two new projects - Data and Web. **[describe how and what exactly to do]**


First we need to register MVC middleware.
'''C#
Add startup code
'''


Lets add a UserController which will return a hardcoded object to ensure that Web API endpoint is accessible and MVC middleware works as expected.


ToDo
* register ef
* add dbcontext
* add model
* init default data
* configure code first
* reset db on model change
* connect controller with db
* showcase (get real user by API)