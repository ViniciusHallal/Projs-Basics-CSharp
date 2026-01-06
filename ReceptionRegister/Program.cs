namespace ReceptionRegister;

public class Program
{
    public static void Main()
    {
        List<Register> ListOfUser = new List<Register>();
        int option;

        do
        {
            Register.DisplayMenu();
            string inputOption = Console.ReadLine();

            if (!int.TryParse(inputOption, out option))
            {
                option = -1;
            }

            switch (option)
            {
                case 1:
                    Register.AddNewUser(ListOfUser);
                    break;
                case 2:
                    Register.ViewAllUsers(ListOfUser);
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\nLeaving the system...");
                    Register.SaveFile(ListOfUser);
                    break;
                default:
                    Console.Write("\nInvalid Option! Press Enter to try again: ");
                    Console.ReadKey();
                    break;
            }
        } while (option != 0);
    }
}