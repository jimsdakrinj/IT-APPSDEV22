
/*
 Name: Turceno, James Gabriel B.
 Program / Year: BSIT - II
 Course: 27417 CC-APPSDEV22
 Date & Time: 11th Day of March, Year of 2026, at 4:15 Post Meridiem. 
 */
using System;
class TurcenoJamesGabrielB_MidtermAct1 {
    public static void Main(string[] args) {
        /*
        Task 1: Create a C# program that:
        Asks the user to input two numbers
        Displays the maximum value using Math.Max()
        Displays the minimum value using Math.Min()
        */

        //asks the user to enter 2 numbers to begin
        Console.Write("Enter number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Minimum: " + Math.Min(num1, num2));  //trying to find the minimum value of the number
        Console.WriteLine("Maximum: " + Math.Max(num1, num2));  //trying to find the maximum value of the number

        /*
         Task 2: Create a C# program that:

            Asks the user to input a number
            Displays its square root using Math.Sqrt()
            Displays the absolute value using Math.Abs()
            Displays the rounded value using Math.Round()
         */

        Console.Write("\n\nEnter number: ");        //asks the user to enter any number.
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Square root: " + Math.Sqrt(num3));       //calculates the value of each method and displaying it.
        Console.WriteLine("Absolute: " + Math.Abs(num3));
        Console.WriteLine("Round off: " + Math.Round(num3));

        /*Task 3: Create a C# program that:

        Uses ALL five Math methods learned (Max, Min, Sqrt, Abs, Round)
        Demonstrates each method with your own example values
        Includes comments explaining what each line does*/

        Console.WriteLine("\n\n\t\t--- Hello Welcome! ---\n");
        Console.WriteLine("Select any operations to begin with: ");
        Console.WriteLine("\n1. Maximum and Minimum (Math.Min and Math.Max): Reads the highest number as the maximum \nand the lowest number as minimum " +
                          "\n2. Square root (Math.Sqrt): returns a square root of a number. "+
                          "\n3. Absolute (Math.Abs): returns a absolute value of a given number. "+
                          "\n4. Round (Math.Round): Rounds a number to the nearest integer. "+
                          "\n5. Exit");
        Console.Write("\nEnter number of choice: ");        //asking the user to enter a number on the menu to start the program.
        int operat = Convert.ToInt32(Console.ReadLine());   //the var operat stores the int value from the ReadLine to start the switch case 

        switch (operat) {

            case 1: //if the user inputs 1 it will fall to the min max method.
                Console.WriteLine("--- You are now choosing Math.Min and Math.Max method ---\n\n"); //informs the user that they are now on the Min Max method.
                Console.Write("Enter a number: ");           //asks the user to input 1st number
                double forMinMaxvar1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");     //asks the user to input 2nd number
                double forMinMaxvar2 = Convert.ToDouble(Console.ReadLine());

                double minMaxVal1 = Math.Min(forMinMaxvar2, forMinMaxvar1);         //calculates the minimum value
                double minMaxVal2 = Math.Max(forMinMaxvar1, forMinMaxvar2);         //calculates the maximum value

                Console.WriteLine("\nMinimum value: " + minMaxVal1);    //Displays the Minimum
                Console.WriteLine("Maximum value: " + minMaxVal2);      //Displays the Maximum Value

                break; //if the program meets the flow criteria it will end the program.

            case 2: //if the user inputs 2 it will fall to the sqrt method.
                Console.WriteLine("--- You are now choosing Math.Sqrt method. ---\n\n"); //informs the user that they are now on the math.sqrt method
                Console.Write("Enter a number: "); //asks the user to input any number
                double sqrVar = Convert.ToDouble(Console.ReadLine());

                double sqrVal = Math.Sqrt(sqrVar); //calculates the Square root of a number

                Console.WriteLine("\nResult: " + sqrVal); //Displays the result.
                break;

            case 3: //if the user inputs 3 it will fall to the abs method.
                Console.WriteLine("--- You are now choosing Math.Abs method. ---");     //informs the user that they are now on the math.abs method.

                Console.Write("\nEnter number: ");      //asks the user to input any number
                double absVar = Convert.ToDouble(Console.ReadLine());

                double absVal = Math.Abs(absVar);       //calculates the absolute value of the number.

                Console.WriteLine("\nResult: " + absVal); //Displays the result as well.
                break;

            case 4: //if the user inputs 4 it will fall to math.round method 
                Console.WriteLine("--- You are now choosing Math.Round method. ---");    //informs the user that they are now on the math.round method.

                Console.Write("Enter any decimal point number: ");          //asks the user to input number.
                double roundVar = Convert.ToDouble(Console.ReadLine());     //declaring variable and converting string to double, and readline reads the input

                double roundVal = Math.Round(roundVar);         //calculates the Round off value of a number

                Console.WriteLine("Result: "+ roundVal);        //Displaying hte result.

                break;

            case 5: //if the user enters 5 it will stop the program
                Console.WriteLine("Exiting the program...");
                break;

            default: //by default if the user inputs any number that doesn't match the menu. It will exit the program.
                Console.WriteLine("Invalid number of choice. Please try again.");
                break;
        }

    }
}
