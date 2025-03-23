using System;

class Program
{
    // Define the Student class with methods for average and grade calculation
    public class Student
    {
        // Declare fields to store the marks for the four subjects
        public int Maths { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int ComputerScience { get; set; }

        // Method to calculate the average of the four subjects
        public double CalculateAverage()
        {
            return (Maths + Physics + Chemistry + ComputerScience) / 4.0;
        }

        // Method to determine the grade based on the average marks
        public string CalculateGrade(double average)
        {
            if (average >= 80)
                return "A";
            else if (average >= 70)
                return "B";
            else if (average >= 60)
                return "C";
            else if (average >= 50)
                return "D";
            else
                return "F";
        }

        // Method to print remarks based on the grade using a switch statement
        public void PrintRemarks(string grade)
        {
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case "B":
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case "C":
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case "D":
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case "F":
                    Console.WriteLine("Fail. Your grade is F");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
        }
    }

    static void Main()
    {
        try
        {
            // Create an instance of the Student class
            Student student = new Student();

            // Accept marks for the four subjects from the user
            Console.Write("Enter marks for Maths (0-100): ");
            student.Maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Physics (0-100): ");
            student.Physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Chemistry (0-100): ");
            student.Chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Computer Science (0-100): ");
            student.ComputerScience = Convert.ToInt32(Console.ReadLine());

            // Calculate the average marks
            double average = student.CalculateAverage();

            // Display the average marks
            Console.WriteLine($"\nYour average marks are: {average:F2}");

            // Calculate the grade based on average marks
            string grade = student.CalculateGrade(average);

            // Display the grade
            Console.WriteLine($"Your grade is: {grade}");

            // Display the remarks based on the grade
            student.PrintRemarks(grade);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter numerical values only.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // Wait for the user to press a key before closing the console
        Console.ReadKey();
    }
}

