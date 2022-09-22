using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class PasswordTwoPattern
    {
        public static void ValidatePassword()
        {
            try
            {
                Console.WriteLine("Enter a password");
                string password=Console.ReadLine();
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMiniChars = new Regex(@".{8,}");
                var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z]).{8,}$");
                if (pattern.IsMatch(password))
                {
                    Console.WriteLine("Password is "+password);
                }
                else if (!hasMiniChars.IsMatch(password))
                {
                    throw (new CustomException("Password should have minimum 8 characters"));
                }
                else if (!hasLowerChar.IsMatch(password))
                {
                    throw (new CustomException("Password should have at least 1 lower char"));
                }
                else if (!hasUpperChar.IsMatch(password))
                {
                    throw (new CustomException("Password should have at leat one upper character"));
                }
                else
                {
                    throw (new CustomException("Invalid Password"));
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
