

namespace UserManagementMicroservice
{
    public class InputValidationOperations
    {
        public static bool ArePasswordsEqual(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
    }
}
