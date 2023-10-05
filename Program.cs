using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                // SwapTwoNos();
                // multiply();
                //operations();
                //  SpecificOperations();
                //  NumberWithSpaces();
                // CelsiusConversion();
                //EqualOrNot();
                AbsoluteValue();
                // DaysIntoYears();
                //MarksGrade();
                // MaxMinOfNos();




                Console.ReadLine();

            }


            private static void MaxMinOfNos()
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int maxNumber = Math.Max(num1, num2);

                int minNumber = Math.Min(num1, num2);

                Console.WriteLine($"Maximum Number: {maxNumber}");
                Console.WriteLine($"Minimum Number: {minNumber}");
            }

            private static void MarksGrade()
            {
                Console.Write("Enter marks in first subject: ");
                int subject1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter marks in second subject: ");
                int subject2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter marks in third subject: ");
                int subject3 = Convert.ToInt32(Console.ReadLine());

                int totalMarks = subject1 + subject2 + subject3;
                double percentage = totalMarks / 300.0 * 100;

                Console.WriteLine($"Total Marks: {totalMarks}");
                Console.WriteLine($"Percentage: {percentage}%");

                if (percentage < 35)
                {
                    Console.WriteLine("Grade: Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    Console.WriteLine("Grade: Third");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    Console.WriteLine("Grade: Second");
                }
                else
                {
                    Console.WriteLine("Grade: First");
                }
            }

            private static void DaysIntoYears()
            {
                Console.Write("Enter the number of days: ");
                int totalDays = Convert.ToInt32(Console.ReadLine());

                int years = totalDays / 365;
                int weeks = totalDays % 365 / 7;
                int remainingDays = totalDays % 365 % 7;

                Console.WriteLine($"Years: {years}");
                Console.WriteLine($"Weeks: {weeks}");
                Console.WriteLine($"Days: {remainingDays}");
            }

            private static void AbsoluteValue()
            {
                Console.Write("Enter the first number: ");
                double Firstno = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double Secondno = Convert.ToDouble(Console.ReadLine());

                double absoluteDifference = Math.Abs(Firstno - Secondno);

                if (Firstno > Secondno)
                {
                    double result = 2 * absoluteDifference;
                    Console.WriteLine($"The absolute difference between {Firstno} and {Secondno} is {absoluteDifference} and the result of two times of absolute difference is: {result}");
                }
                else
                {
                    Console.WriteLine($"The absolute difference between {Firstno} and {Secondno} is: {absoluteDifference}");
                }
            }

            private static void EqualOrNot()
            {
                Console.Write("Enter the first integer: ");
                int Firstno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second integer: ");
                int Secondno = Convert.ToInt32(Console.ReadLine());
                int sum = Firstno + Secondno;
                if (Firstno == Secondno)
                {
                    int result = 3 * sum;
                    Console.WriteLine($"The values of firstnumber,secondnumber {Firstno} , {Secondno} are equal so, Triple of their sum is: {result}");
                }
                else
                {
                    Console.WriteLine($"The values of firstnumber,secondnumber {Firstno} , {Secondno} are not equal ");
                }
            }

            private static void CelsiusConversion()
            {
                Console.Write("Enter the amount of Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double kelvin = celsius + 273.15;
                double fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine($"Kelvin = {kelvin}");
                Console.WriteLine($"Fahrenheit = {fahrenheit}");
            }

            private static void NumberWithSpaces()
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"{number} {number} {number} {number}");
                Console.WriteLine($"{number}{number}{number}{number}");
                Console.WriteLine($"{number} {number} {number} {number}");
                Console.WriteLine($"{number}{number}{number}{number}");
            }


            private static void SpecificOperations()
            {
                int Firstno;
                int Secondno;
                int Thirdno;
                Console.WriteLine("input the first number to multiply:");
                Firstno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the second number to multiply:");
                Secondno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the third number to multiply:");
                Thirdno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result of specified numbers{Firstno},{Secondno}.{Thirdno} (x+y).z is {(Firstno + Secondno) * Thirdno} and x.y+y.z is {Firstno * Secondno + Secondno * Thirdno}");
            }

            private static void operations()
            {
                int Firstno;
                int Secondno;
                Console.WriteLine("input the first number:");
                Firstno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the second number:");
                Secondno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{Firstno}+{Secondno}={Firstno + Secondno}");
                Console.WriteLine($"{Firstno}-{Secondno}={Firstno - Secondno}");
                Console.WriteLine($"{Firstno}*{Secondno}={Firstno * Secondno}");
                Console.WriteLine($"{Firstno}/{Secondno}={Firstno / Secondno}");
                Console.WriteLine($"{Firstno} mod {Secondno}= {Firstno % Secondno}");
            }

            private static void multiply()
            {
                int Firstno;
                int Secondno;
                int Thirdno;
                Console.WriteLine("input the first number to multiply:");
                Firstno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the second number to multiply:");
                Secondno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the third number to multiply:");
                Thirdno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{Firstno}*{Secondno}*{Thirdno}={Firstno * Secondno * Thirdno}");
            }

            private static void SwapTwoNos()
            {
                int Firstno;
                int Secondno;
                int temp;

                Console.WriteLine("input the first number:");
                Firstno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the second number:");
                Secondno = Convert.ToInt32(Console.ReadLine());
                temp = Firstno;
                Firstno = Secondno;
                Secondno = temp;
                Console.WriteLine("After Swapping");
                Console.WriteLine($"First number : {Firstno}");
                Console.WriteLine($"Secong number : {Secondno}");
            }



        }

    }
