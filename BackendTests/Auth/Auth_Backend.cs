//remo authentication backend test

// 6/6/25 4:25pm
/* //added inside folder 4:51pm
log in status logic
isOwner and Login Form Auth
separate file for Forgot password, assuming its in a different window/file too
exit button destroy/close app/window will be easy to add when frontend okay
*/

using System;

class Auth_Backend //renamed class
{
    static (bool, int) checkLoggedAcc()
    {
        //changeable function name
        //checks detail of logged in user

        //we can do my logic here or use a diff one
        //upon logging in, we do file handling
        // = save that user info in the file and take their PK
        // = call database and pass logged in users PK
        // = use that as current logged users detail to skip logging in again
        //upon logging out, rewrite the file with empty content or something else
        // = reads file, if empty content go directly to logging in

        // function or file handling logic here

        int loggedUser_id = 0; // 0 as temporary default value
        bool isLogged_in = false; // false as temporary default value
        return (isLogged_in, loggedUser_id);
    }

    static bool isOwner(int user_id)
    {
        // do sql reading here
        // use the passed user_id to check in sql if that user is the owner

        // temporary initialized to false for now, so user gets redirected to auth
        bool is_IdOwners = false;
        return is_IdOwners;
    }

    static bool authenticationFunct()
    {
        try
        {
            // get value from username textbox / entry widget
            // get value from password textbox / entry widget
            string username_Input = username.Text;
            string password_Input = password.Text;

            // do basic read sql // check if username_Input exists in databas
            // check if username_Input exists in database

            // save users id
            string userId_fromDb;

            // save that users id and collect its password
            // assign it to this /* password_fromDb */ and check
            string password_fromDb;
            if (password_Input == password_fromDb)
            {
                //temporary print for checking
                Console.WriteLine("Correct password");
                return userId_fromDb;
            }
            else
            {
                //temporary print for checking
                Console.WriteLine("Incorrect password");
                //code to do next
            }
        }
        catch (Exception ex)
        {
            // temporary print for checking
            Console.WriteLine($"Login error: {ex.Message}");
            // code to do next
        }
    }

    static void Main()
    {
        // Get the login status
        (bool status, int user_id) = checkLoggedAcc();

        if (status)
        {
            bool owner = isOwner(user_id);
            if (owner)
            {
                //temporary print for checking
                Console.WriteLine("User is owner - proceed with owner logic.");
                //code to do next
            }
            else
            {
                //temporary print for checking
                Console.WriteLine("User is NOT owner - proceed with other logic.");
                //code to do next
            }
        }
        else
        {
            // redirects user to authentication
            // login form and forgot password form
            int loggedInUserId = authenticationFunct();

            if (loggedInUserId != 0)
            {
                bool owner = isOwner(loggedInUserId);
                if (owner)
                {
                    //temporary print for checking
                    Console.WriteLine("User is owner - proceed with owner logic.");
                    //code to do next
                }
                else
                {
                    //temporary print for checking
                    Console.WriteLine("User is NOT owner - proceed with other logic.");
                    //code to do next
                }
            }
        }
    }

}

/* Function syntax
<return_type> <FunctionName>(<parameter_type> <parameter_name>)
{
    // code
    return value;
}
*/