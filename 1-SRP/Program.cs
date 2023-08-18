using _1_SRP;
using _1_SRP.Following;
using _1_SRP.Violating;

User user = new()
{
    Name = "user",
    Email = "user@email.com",
    Password = "password"
};

// Bad Example (Violating SRP)
var isAuthenticateBad = UserAuthenticationBad.AuthenticateOrRegisterUser(user);
Console.WriteLine("Bad Example (Violating SRP)");
Console.WriteLine($"AuthenticateOrRegisterUser is {isAuthenticateBad}");
// Bad Example (Violating SRP)

Console.WriteLine();

// Good Example (Following SRP)
try
{
    var isAuthenticateGood = UserAuthenticationGood.Authenticate(user.Email, user.Password);
    if (isAuthenticateGood)
    {
        // Do something
        Console.WriteLine("Good Example (Following SRP)");
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