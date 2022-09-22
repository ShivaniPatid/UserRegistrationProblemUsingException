using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class EmailSamples
    {
        public static void ValidateEmail()
        {
            try
            {
                Console.WriteLine("Enter a email");
                string email = Console.ReadLine();
                string pattern = @"^([a-z]+)([._+-a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2,4})?$";

                if (Regex.IsMatch(email, pattern))
                {
                    Console.WriteLine("Email : "+email);
                }
                else
                {
                    throw new CustomException(email+"email is not valid");
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
