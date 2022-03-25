class Program
{
    static void Main()
    {
        //display title
        System.Console.WriteLine("*************** My Bank ****************");
        System.Console.WriteLine("::Login Page::");

        //declare variables to store username and password
        string userName = null, password = null;
        int mainMenuChoice = -1;

        //read userName from keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        //read password from keyboard only if username was entered
        if (userName != null)
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if (userName == "system" && password == "manager")
        {
            do
            {
                //declare variable to store menu choice
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //check menu choice
                switch (mainMenuChoice)
                {
                    case 0: //Exit
                        break;
                    case 1:
                        CustomersMenu(); // Display customers menu
                        break;
                    case 2: AccountsMenu(); // Display accounts menu
                        break;
                    case 3: // Display funds transfer menu
                        break;
                    case 4: // Display funds transfer statement menu
                        break;
                    case 5: // Display account statement menu
                        break;
                    default:
                        System.Console.WriteLine("Error");
                        break;
                }
                
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }
        
        //about to exit
        System.Console.WriteLine("Thank you. Visit us again!");
        System.Console.ReadKey();

    }

    static void CustomersMenu()
    {
        //declare variable to store customers menu choice
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");
            //customerMenuChoice = int.Parse(System.Console.ReadLine()); //option 1 to convert to int
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine()); //option 2 to convert to int

        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //declare variable to store customers menu choice
        int accountsMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Accounts Menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");
            accountsMenuChoice = int.Parse(System.Console.ReadLine()); //option 1 to convert to int
            //customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine()); //option 2 to convert to int

        } while (accountsMenuChoice != 0);
    }
}