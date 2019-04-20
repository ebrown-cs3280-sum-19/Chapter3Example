using System;
using System.Collections.Generic;
using System.Text;

//Add this reference
using System.Windows.Forms;

namespace Chapter_3_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //This is a comment
            Console.WriteLine("Hello World");
            Console.ReadLine();

            //Shows escape characters
            Console.WriteLine("Hello\t World \nprogram test");
            Console.ReadLine();

            //Create variables
            string input;
            int secondNumber;
            int sum;

            //Get the numbers
            Console.Write("Enter First Number: ");
            input = Console.ReadLine();
    
            //Convert                v inline variable declaration
            int.TryParse(input, out int firstNumber); // will set out to 0 and return false if fails
            Console.Write("Enter Second Number: ");

            input = Console.ReadLine();
            secondNumber = Convert.ToInt32(input); // will throw an exception if fails


            //Add the numbers
            sum = firstNumber + secondNumber;

            //Display the total
            MessageBox.Show($"The sum of {firstNumber} and {secondNumber} is {sum}", "Sum",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            //If statements
            if (firstNumber > secondNumber)
            {
                MessageBox.Show($"{firstNumber} is greater than {secondNumber}");
            }

            if (firstNumber < secondNumber)
            {
                MessageBox.Show($"{firstNumber} is less than {secondNumber}");
            }

        }
    }
}
