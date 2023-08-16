namespace _1_SRP.Violating
{
    public class UserAuthenticationBad
    {
        public static bool AuthenticateOrRegisterUser(User user)
        {
            try
            {
                // Code to authenticate user against a database
                var isAuthenticate = true;

                if (isAuthenticate)
                {
                    // Do something
                    return true;
                }
                else
                {
                    // Code to register user
                    // Code to send email notifications
                }
            }
            catch (Exception ex)
            {
                // Code to log authentication activity
            }

            return false;
        }
    }
}
