# .Net Core and basics of authentication

My primary focus is frontend apps. Although I used to be a .Net developer. And I always loved how fast and convenient EF Code First is on a product prototype phase. For one of my pet project I decided to build backend server with the latest (May 2017) versions of .Net Core, EF Core and Postgres database. I had deleted Visual Studio and has used Visual Studion Code. Which is a whole different tool. As you may guess things that are essentian in VS just do not exist in other IDEs (even if authored by Microsoft).


In this article I will explain how to add authentication to .Net Core project. I will not touch here how to create a .Net Core Web API application and connectit with a database. If you are interested read the previous article [.Net Core, Entity Framework Core and PostgreSQL](../). The first part shows the concept of Custom middlewares and Action Filters - I'm going to create my own authorization and authentication middleware. The second part describes how to use authentication mechanisms provided by the .Net Core framework.
At end of the lession we will have a tiny web API application that can handle user authentication, authorization and have protected actions.


#Authentication

Authenticatin in this example is done by the [OAuth2 password grant flow](https://aaronparecki.com/oauth-2-simplified). It allows to exchange username and password for an access token. Obviously, in this case user credentials can be collected by the web app, but that's fine in our case since the web client and the authentication server are provided by us (meaning by the same company).


Let's add users to our database.
```
update db seader
```

We need to handle login request. Add the Auth controller.

# ToDo
* read about auth2 password flow
* implement the custom authorization
* implement the custom authentification
* use the .Net provided authorization mechanism
* use the .Net provided attribute authentification