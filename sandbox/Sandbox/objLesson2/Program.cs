using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!!");
        // do not coppy above
        Console.Write("What is your First Name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your Last Name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name}, {last_name}");
        // second Program
        Console.Write("What was your grade in percentage points? ");
        string numberFromUser = Console.ReadLine();
        float number = float.Parse(numberFromUser);

        if (number >= 90){
            string grade = "A";
        Console.WriteLine($"{first_name} your grade is a {grade}");

        }
        else if (number >= 80){
            string grade = "B";
        Console.WriteLine($"{first_name} your grade is a {grade}");

        }
        else if (number >= 70){
            string grade = "C";
        Console.WriteLine($"{first_name} your grade is a {grade}");

        }
        else if (number >= 60){
            string grade = "D";
        Console.WriteLine($"{first_name} your grade is a {grade}");
        }
        else if (number < 60){
            string grade = "F";
        Console.WriteLine($"{first_name} your grade is a {grade}");
        }
    }
}