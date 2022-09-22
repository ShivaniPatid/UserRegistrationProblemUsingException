namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option");
            Console.WriteLine("Chosee a oprtion");
            Console.WriteLine("1. UC1 - Validate First Name");
            Console.WriteLine("2. UC2 - Validate Last Name");
            Console.WriteLine("3. UC3 - Validate Email Address");
            Console.WriteLine("4. UC4 - Validate Mobile Number");
            Console.WriteLine("5. UC5 - Validate password Rule1 - Password should have minimum 8 characters");
            Console.WriteLine("6. UC6 - Validate password Rule2 - Password should have at least 1 upper character");
            Console.WriteLine("7. UC7 - Validate password Rule3 - Password should have at least 1 numeric number");
            Console.WriteLine("8. UC8 - Validate password Rule4 - Password should have at least 1 special character");
            Console.WriteLine("9. UC9 - email samples provided separately");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FirstNamePattern.ValidateFirstName();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
        }
    }
}