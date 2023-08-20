namespace _4_ISP.Violating
{
    public class GuestUser : IUser
    {
        // it will be forced to provide implementations for all these methods,
        // even if it doesn't need all of them.

        public void ViewDashboard()
        {
            // Implement methods for viewing the dashboard
        }

        public void Login()
        {
            // This user doesn't need this functionality
            throw new NotImplementedException();
        }

        public void Logout()
        {
            // This user doesn't need this functionality
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            // This user doesn't need this functionality
            throw new NotImplementedException();
        }

        public void UploadFile()
        {
            // This user doesn't need this functionality
            throw new NotImplementedException();
        }
    }
}
