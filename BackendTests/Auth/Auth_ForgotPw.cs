//remo authentication backend test

// 6/6/25 4:50pm //my laptop time is advanced a bit, idk like 3mnts ig
/*
forgot password logic
can copy isOwner here if forgot password front end is on a different page
no sql reading
*/

using System;
using System.Text.RegularExpressions; //to access special characters 

class Program
{
    static bool checkUser(string username_Input)
    {
        // do basic read sql // check if username_Input exists in database
        // = and assign its username and id in this variables
        string username_fromDb;
        if (username_Input == username_fromDb)
        {
            //temporary print for checking
            Console.WriteLine("Username Found");
            return true;
        }
        else
        {
            //temporary print for checking
            Console.WriteLine("Username not found");
            return false;
        }
    }
    
    static bool checkPassword(string password)
    {
        // Checks length > 8
        if (password.Length <= 8)
            return false;

        // Regex to check for at least one special character
        // This matches any character that is NOT a letter or digit
        Regex specialCharRegex = new Regex(@"[^a-zA-Z0-9]");

        if (!specialCharRegex.IsMatch(password))
            return false;

        return true;
    }

    static bool forgotPw()
    {
        // get value from username textbox / entry widget and pass it to the function
        string username_Input = username.Text;
        bool userFound = checkUser(username_Input);

        if (userFound)
        {
            try
            {
                // get value from password textbox / entry widget
                string password_Input = password.Text;
                if (checkPassword(password_Input)) //this logic is from chatgpt but ight
                {
                    //temporary print for checking
                    Console.WriteLine("Password updated successfully");
                    // proceed back to login page or make user log in directly
                    // if login directly copy isOwner function here and run it first
                }
                else
                { 
                    //temporary print for checking
                    Console.WriteLine("Password must be more than 8 characters and contain atleast one special character.");
                }
            }
            catch (Exception ex)
            {
                // temporary print for checking
                Console.WriteLine($"Login error: {ex.Message}");
                // code to do next
            }
        }
    }

    static void Main()
    {
        forgotPw();
    }

}

/* Function syntax
<return_type> <FunctionName>(<parameter_type> <parameter_name>)
{
    // code
    return value;
}
*/