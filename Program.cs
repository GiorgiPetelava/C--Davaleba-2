using System;

class Lesson2
{
    static void Main(string[] args)
    {
        getSum();

        Console.WriteLine();

        Console.WriteLine(GetSum1());
        Console.WriteLine(getFunction(11, 11));
        Console.WriteLine(FormulaBmi(81.4, 1.75));
        FullData();

        Console.ReadKey();
    }
    static void getSum()
    {
        // დავალება 1: შექმენით მეთოდი. მასში გამოაცხადეთ ორი int-ის ტიპის ცვლადი.
        // გამოიყვანეთ მათი ჯამი კონსოლში;
        int number1 = 123;
        int number2 = 232;

        Double Sum = number1 + number2;

        Console.WriteLine(Sum);
    }
    static int GetSum1()
    {
        int number1 = 121;
        int number2 = 100;

        return number1 + number2;
    }

    static double getFunction(double num1, double num2)
    {
        //დავალება 2:შექმენით მეთოდი. მეთოდი Main-დან გადაეცით ახალ მეთოდს ორი double-ის ტიპის ცვლადი.
        //დააბრუნეთ ამ ორი double-ის ტიპის ცვლადების ჯამი. გამოიყვანეთ კონსოლში.

        return num1 + num2;
    }
    //დავალება 4:
    static double FormulaBmi(double weight, double height)
    {
        // დაწერეთ BMI გამოთვლის კოდი.

        double BMI = weight / (height * height);
        return BMI;
    }
    //დავალება 5:
    static void FullData()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter your surname");
        string userSurname = Console.ReadLine();
        Console.WriteLine("Age");
        string userAge = Console.ReadLine();
        Console.WriteLine("Enter Weight");
        string userWeight = Console.ReadLine();
        Console.WriteLine("Enter Bmi");
        string userBmi = Console.ReadLine();
        Console.WriteLine("Your name is " + userName +
            "\nYour surname is " + userSurname +
            "\nYour Age is " + userAge +
            "\nYour weight is " + userWeight +
            "\nYour Bmi is " + userBmi);
    }

}
