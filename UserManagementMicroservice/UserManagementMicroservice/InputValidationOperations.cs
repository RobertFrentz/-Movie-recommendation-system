using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
