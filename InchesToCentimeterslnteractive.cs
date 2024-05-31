using System;

class Program {
  public static void Main (string[] args) 
  {
    //Declare constant for inches to centimeters conversion
    const double CENTIMETERS_PER_INCH = 2.54;
    
    //Prompt user for inches and read input from console
    Console.Write("Enter a number of inches: ");
    var inches = Console.ReadLine();

    //Declare variable to store parsed int value. If parsing is successful, convert inches to centimeters. If not, display an error message.
    int inchesAsNumber;
    if (int.TryParse(inches, out inchesAsNumber)) {
      Console.WriteLine("{0} inches is {1} centimeters", inchesAsNumber, inchesAsNumber * CENTIMETERS_PER_INCH);
    }
    else {
    Console.WriteLine("Invalid input. Please enter numbers only.");
    }
  }  
}