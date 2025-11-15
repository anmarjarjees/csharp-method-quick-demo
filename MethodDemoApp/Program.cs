using System;

namespace MethodDemoApp
{
    /* 
     In General, OOP has three access modifiers:
     - public
     - private
     - protected  

    Optional Step:
    C# also has "internal", we can make it "public"
     */
    public class Program
    {
        /* 
        Main => is the initial standard required "method"
        to run our application.
        It's the main entry point to run our app,
        that's why it's called "Main"

        Main() => is our first example of a method
        Main() => built-in method for C#
        we can just write our code inside it
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Working with methods");

            Console.WriteLine("");
            // We can NOT create our method inside the Main()
            // We can just call/run our method(s) here:
            SayHello(); // :-(
            /*
            Error:
            An object reference is required 
            for the non-static field, method, or property 'Program.SayHello()'

            the keyword => "non-static" 
            we also have the "static"

            "static"  => means this method belongs to the class itself.
            Example: Main() method => belongs to => class Program { }

            IMPORTANT NOTE: 
            ***************
            Because the Main() method is "static",
            every method we call inside the Main() must also be "static"
            */

            /* 
            Error:
            There is no argument given that corresponds 
            to the required parameter 'username' of 'Program.GreetUser(string)'

            Argument => "Alex Chow"
             */
            GreetUser("Alex Chow");

            // calling our lb to kg converting method:
            // 23 => the argument
            double kgValue1 = ConvertToKg(23);
            Console.WriteLine("23Lb is: " + kgValue1);

            Console.WriteLine("26lb is " + ConvertToKg(26));

        } // Main()

        /* 
        Question: What about creating our own method to solve something?
        Answer: Yes, let's do it!
         */
        /*
        * Our Custom Methods:
        *********************
        * - Must be created inside a class
        * - CANNOT be created inside Main()
        
        *
        Method => is just a function inside a class1 
        * Two Process/stages:
        * 1) Create our method (outside Main)
        * 2) Calling our method (inside Main)

        Method basic required Template:
        ******************************
        ReturnType MethodName() {
        
        }

        We need to add the keyword "static" in some cases!
        */

        // 1. Create a method so say hello everyone!
        // Error: Method must have a return type
        static void SayHello()
        {
            Console.WriteLine("Hello everyone!");
            // notice that this method does NOT return anything!
            // this method does NOT have the keyword "return"
            // return;
        }

        // 2. Create a method so say hello + user name
        // Example: Hello Alex, Hello kate,....
        /* 
        Methods (Functions):
        *******************
        - Parameter(s) => username
        - Argument(s) => "Alex", "Chow",...
         */
        static void GreetUser(string username)
        {
            Console.WriteLine($"Hello {username}");
        }

        // Add more interesting methods!!!
        /* 
        Task#1 => a method to convert LB to KG:
        - need to accept a the mass value in LB
        - do the calculation to make it in KG
        - print/return the value of kg
            > for just printing => "void"
            > for returning the mass value in Kg => double
        
        Tip:
        Formula (Google):
        for an approximate result, divide the mass value by 2.205
        */

        // lbValue => is the parameter:
        static double ConvertToKg(double lbValue)
        {
            // divide the mass value by 2.205
            double kgValue = lbValue / 2.205;
            /* 
                "return" has two actions:
                *************************
                - return a value of any data type
                - Terminate/stop my function as this line
                */
            return kgValue; // will give us the value in KG
            // Warning: Unreachable code detected:
            // Any code below the "return" will never run
            Console.WriteLine("KG Value: " + kgValue);
        }

        /*  
        Task to enjoy!:
        Task#2 => a method to convert KG to LB:
        - same idea as with the other one
        Formula:
        for an approximate result, multiply the mass value by 2.205
        */

        /* 
        Assignment Task:
        ****************
        - Creating 3 required method(s):
        - Method1: takes first name and last name => printing the full name
        - Method2: C to F Formula: (0°C × 9/5) + 32 = 32°F
        - Method3: F to C Formula : (32°F − 32) × 5/9 = 0°C
        - Method4: Any thing of your choice!
        */

    } // class

    // For this task we should NOT create our method or writing any other code here!
} // namespace
