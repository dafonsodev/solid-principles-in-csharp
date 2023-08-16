// See https://aka.ms/new-console-template for more information
using _1_SRP;
using _1_SRP.Following;
using _1_SRP.Violating;

Console.WriteLine("Hello, World!");

User user = new()
{
    Name = "user",
    Email = "user@email.com",
    Password = "password"
};

// Bad Example (Violating SRP)
var isAuthenticateBad = UserAuthenticationBad.AuthenticateOrRegisterUser(user);
Console.WriteLine($"AuthenticateOrRegisterUser is {isAuthenticateBad}");
// Bad Example (Violating SRP)


// Good Example (Following SRP)
try
{
    var isAuthenticateGood = UserAuthenticationGood.Authenticate(user.Email, user.Password);
    if (isAuthenticateGood)
    {
        // Do something
        Console.WriteLine($"Authenticate is {isAuthenticateGood}");
    }
    else
    {
        Register.AddUser(user);
        AuthenticationLogger.LogAuthentication("user has been successfully created!");
    }

}
catch (Exception ex)
{
    AuthenticationLogger.LogAuthentication(ex.Message);
}
// Good Example (Following SRP)