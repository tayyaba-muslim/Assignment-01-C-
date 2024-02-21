// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Grade Calculator ");

//Console.WriteLine("Enter the marks for Mathematics: ");
//int MathMarks = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the marks for Science: ");
//int ScienceMarks = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the marks for English: ");
//int EnglishMarks = Convert.ToInt32(Console.ReadLine());

//if (MathMarks >= 0 && MathMarks <= 100 && ScienceMarks >= 0 && ScienceMarks <= 100 && EnglishMarks >= 0 && EnglishMarks <= 100)
//{
//    int totalMarks = MathMarks + ScienceMarks + EnglishMarks;
//    Console.WriteLine("\nTotal Marks: " + totalMarks + "/300");

//    var averageMarks = totalMarks / 3;



//    switch (averageMarks / 10)
//    {
//        case 9:
//        case 10:
//            Console.WriteLine("finalGrade = 'A'");
//            break;
//        case 8:
//            Console.WriteLine("finalGrade = 'B'");
//            break;
//        case 7:
//            Console.WriteLine("finalGrade = 'C'");
//            break;
//        case 6:
//            Console.WriteLine("finalGrade = 'D'");
//            break;
//        default:
//            Console.WriteLine("finalGrade = 'F'");
//            break;
//    }

//    Console.WriteLine($"Average Marks: {averageMarks}");
//    int finalGrade;

//}
//else
//{
//    Console.WriteLine("Invalid input: Please enter valid marks for all subjects.\n Marks range from 0 to 100.");
//}

//Temperature Converter

Console.WriteLine("Choose the temperature scale to convert from:");
Console.WriteLine("1. Celsius");
Console.WriteLine("2. Fahrenheit");
Console.Write("Enter your choice: ");

int choice = Convert.ToInt32(Console.ReadLine());



switch (choice)
{
    case 1:

        Console.WriteLine($"Enter the temperature in : ");
        int Celsius = Convert.ToInt32(Console.ReadLine());
        var temp = (Celsius * 9 / 5) + 32;
        Console.WriteLine("\n" + Celsius + " °C." + " is equal to " + temp + " °F.");
        Console.WriteLine("Thank you for using the temperature converter!");

        break;
    case 2:
        Console.WriteLine($"Enter the temperature in : ");
        int Fahrenheit = Convert.ToInt32(Console.ReadLine());
        var tempp = (Fahrenheit - 32) * 5 / 9;
        Console.WriteLine("\n" + Fahrenheit + " °F." + " is equal to " + tempp + " °C.");
        Console.WriteLine("Thank you for using the temperature converter!");

        break;

    default:
        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        break;

}






