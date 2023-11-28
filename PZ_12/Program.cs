namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.WriteLine("Введите адрес электронной почты:");
                string email = Console.ReadLine();

                bool isValidEmail = IsValidEmail(email);
                Console.WriteLine(isValidEmail);
            }

            static bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
