using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace programmingPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //C# PROGRMMING PRACTICE SET...
            //===================================================================

            //C# Program to Check Whether a Given Number is Even or Odd
            //C# Program to Print Odd Numbers in a Given Range
            //C# Program to Check Whether a Number is Positive or Not
            //C# Program to Find the Largest of Two Numbers
            //C# Program to Swap Two Numbers
            //C# Program to Check if a Number is Divisible by 2
            //C# Program to Find the Sum of All the Multiples of 3 and 5
            //C# Program to Print All the Multiples of 17 which are Less than 100
            //C# Program to Find Sum of Digits of a Number
            //C# Program to Find Sum of Digits of a Number using Recursion
            //C# Program to Reverse a Number
            //C# Program to Reverse a Number and Check if it is a Palindrome
            //C# Program to Find the Sum of Two Binary Numbers
            //C# Program to Multiply Two Binary Numbers
            //C# Program to Calculate the Sum, Multiplication, Division and Subtraction of Two Numbers
            //C# Program to Perform Multiplication of Exponents of Same Base
            //C# Program to Find the Division of Exponents of Same Base
            //C# Program to Print Binary Equivalent of an Integer using Recursion
            //C# Program to Print Multiplication Table
            //C# Program to Read a Grade and Display the Equivalent Description
            //C# Program to Convert Lowercase Characters by Uppercase and Vice-Versa
            //C# Program to Accept the Height of a Person and Categorize as Taller, Dwarf & Average   

            //===================================================================

            //QUESTION 1 C# Program to Check Whether a Given Number is Even or Odd

            //string confirm;
            //do
            //{
            //    Console.WriteLine("Write a Number.");
            //    int num = int.Parse(Console.ReadLine());

            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("{0} is even number", num);
            //    }
            //    else if (num % 2 == 1)
            //    {
            //        Console.WriteLine("{0} is odd number", num);
            //    }

            //    Console.WriteLine("Want to continue type yes.");
            //    confirm = Console.ReadLine();
            //} while (confirm == "yes");

            //QUESTION 3:  C# Program to Check Whether a Number is Positive or Not



            //string confirm;
            //do
            //{
            //    Console.WriteLine("Write a Number.");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        Console.WriteLine("{0} is positive number", num);
            //    }
            //    else if (num < 0)
            //    {
            //        Console.WriteLine("{0} is negative number", num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is neutral number", num);

            //    }
            //    Console.WriteLine("Want to continue type yes.");
            //    confirm = Console.ReadLine();
            //} while (confirm == "yes");


            //QUESTION 2. C# Program to Print Odd Numbers in a Given Range.
            //Method 1 without range
            //string confirm;
            //do {
            //    Console.WriteLine("Write a Number.");
            //    int num = int.Parse(Console.ReadLine());

            //    if(num % 2 == 1)
            //    {
            //        Console.WriteLine("{0} is even number",num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} not a even number", num);
            //    }
            //        Console.WriteLine("Want to continue type yes.");
            //    confirm = Console.ReadLine();
            //} while (confirm == "yes");


            //Method 2 with range

            //string confirm;
            //do
            //{

            //    //we can set a range in condition of this loop e.g i<10;
            //    for(int i = 0; i < 10; i++)
            //    {
            //        if(i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    Console.WriteLine("Want to continue type yes.");
            //    confirm = Console.ReadLine();
            //} while (confirm == "yes");

            //QUESTION 4. C# Program to Find the Largest of Two Numbers.
            // Nested math.max() method BUT IT GIVES US ONLY ONE VALUE IN RESULT;
            //string confirm;
            //do
            //{
            //    Console.WriteLine("Enter the value 1");
            //    int val1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the value 2");
            //    int val2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the value 3");
            //    int val3 = int.Parse(Console.ReadLine());

            //    int maxVal = Math.Max(val1, Math.Max(val2, val3));
            //    Console.WriteLine("the maximum value is {0} ", maxVal);

            //    Console.WriteLine("want to continue type yes");
            //    confirm = Console.ReadLine();

            //} while (confirm == "yes");


            //Method 2
            //string confirm;
            //do
            //{
            //    Console.WriteLine("Enter first value");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter second value");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter third value");
            //    int num3 = int.Parse(Console.ReadLine());

            //    if (num1>num2 && num1>num3)
            //    {
            //        if (num2 > num3)
            //        {
            //            Console.WriteLine("{0} and {1} are  greater numbers",num1,num2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} and {1} are  greater numbers", num1, num3);
            //        }
            //    }else if (num2 > num1 && num2 > num3)
            //    {
            //        if (num1 > num3)
            //        {
            //            Console.WriteLine("{0} and {1} are  greater numbers", num1, num2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} and {1} are  greater numbers", num3, num2);
            //        }
            //    }
            //    else if (num3 > num1 && num3 > num2)
            //    {
            //        if (num1 > num2)
            //        {
            //            Console.WriteLine("{0} and {1} are  greater numbers", num1, num3);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} and {1} are  greater numbers", num3, num2);
            //        }
            //    }

            //        Console.WriteLine("want to continue type yes");
            //    confirm = Console.ReadLine();

            //} while (confirm == "yes");

            //QUESTION 5.C# Program to Swap Two Numbers.

            //int a = 20;
            //int b = 10;
            //by creating a third variable.

            //int c = b;
            //a = c;

            //by arithemethic operater
            //a = a - b;
            //b = b + a;
            //Console.WriteLine(a);

            //With for loop
            //for (b = 10; b <= 20; b++)
            //{
            //    if (b == 20)
            //    {
            //        Console.WriteLine("value of a is {0}", b);
            //    }
            //}
            //for (a = 20; a >= 10; a--)
            //{
            //    if (a == 10)
            //    {
            //        Console.WriteLine("value of b is {0}", a);
            //    }
            //}

            //by creating temp variable

            //by deconstruction method

            //(a, b) = (b, a);
            //Console.WriteLine("the value of a is {0}",a);
            //Console.WriteLine("the value of b is {0}",b);

            //QUESTION 5 C# Program to Check if a Number is Divisible by 2.
            //int num = 5; ;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("{0}, this number is divisible by 2 ",num);
            //}
            //else
            //{
            //    Console.WriteLine("{0}, this number is not divisible by 2 ", num);
            //}


            // C# Program to Find the Sum of All the Multiples of 3 and 5





            //==================================10 MAY CLASS==================================
            //int[] numbers = new int[4];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] numbers = new string[4];
            //numbers[0] = "imran";
            //numbers[1] = "subhan";
            //numbers[2] = "kashif";
            //numbers[3] = "kashif";

            //foreach (var items in numbers)
            //{
            //    Console.WriteLine(items);
            //}

            //int[,] myarray = new int[3, 4]
            //{
            //    {14,65,55,35 },
            //    {52,78,68,78 },
            //    {88,55,42,68 }
            //};

            //for (int i = 0; i < myarray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myarray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(myarray[i, j] + "");
            //    }
            //}
            //foreach (var items in myarray)
            //{
            //    Console.WriteLine(items);
            //}
            //Console.WriteLine(myarray[2,0]);


            //Console.WriteLine("enter the index number");
            //int num = int.Parse(Console.ReadLine());
            //string[] students = new string[num];
            //for( int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("enter the student name");
            //    students[i] = Console.ReadLine();
            //}

            //    Console.WriteLine("enter the students name");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}







            //// Ask the user for the number of students (length of the array)
            //Console.WriteLine("Enter the number of students:");
            //    int numberOfStudents = int.Parse(Console.ReadLine());

            //    // Create an array to store student names
            //    string[] studentNames = new string[numberOfStudents];

            //    // Loop through the array and ask for each student's name
            //    for (int i = 0; i < numberOfStudents; i++)
            //    {
            //        Console.WriteLine($"Enter the name of student {i + 1}:");
            //        studentNames[i] = Console.ReadLine();
            //    }

            //    // Display the names of all students
            //    Console.WriteLine("\nThe names of the students are:");
            //    for (int i = 0; i < numberOfStudents; i++)
            //    {
            //        Console.WriteLine($"Student {i + 1}: {studentNames[i]}");
            //    }


            //jagged array

            //int[][] myarray = new int[4][];
            //myarray[0] =new[] {12,52,45,47,58,45,54,45,};
            //myarray[1] = new[] { 12, 52,54, 45, };
            //myarray[2] = new[] { 17, 82, 35, 47,45, };
            //myarray[3] = new[] { 10, 43, 95, 7, 58, 45, 54, 45, };

            //for(int i =0;  i < myarray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < myarray.Length; j++)
            //    {
            //        Console.WriteLine(myarray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(myarray[0][5]);

            //int[][] myarray_1 = new int[0][];
            //myarray_1[0] = new[] { 12, 52, 45, 25 };


            //int[][] jaggads = new int[4][];
            //jaggads[0] = new[] { 12, 52, 45, 47, 58, 45, 54, 45, };
            //jaggads[1] = new[] { 12, 52, 54, 45, };
            //jaggads[2] = new[] { 17, 82, 35, 47, 45, };
            //jaggads[3] = new[] { 10, 43, 95, 7, 58 };

            //foreach (int[] items in jaggads)
            //{
            //    foreach (int i in items)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine();

            //}



            //Program ali= new Program();
            //ali.java();
            //string confirm;
            //do
            //{
            //Console.WriteLine("enter value 1");
            //int value1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter value 2");
            //int value2 = int.Parse(Console.ReadLine());
            //Program.add(value1, value2);

            //} while (confirm == "yes");

            // Console.WriteLine("enter first name ");
            //string fname = Console.ReadLine();

            // Console.WriteLine("enter last name");
            // string  lname = Console.ReadLine();

            // Program fullname= new Program();
            // fullname.name(fname,lname);

            //Console.WriteLine("enter your name ");
            //string name = Console.ReadLine();

            //Console.WriteLine("enter your age is");
            //int age = int.Parse(Console.ReadLine());

            //Program show = new Program();
            //show.showAgeName(name , age);

            //showAgeName(name , age);

            //Console.WriteLine("enter first number");
            //int Fnum = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number");
            //int Snum = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter operater number : +,-,*,/");
            //string sign = Console.ReadLine();

            //if (sign.Equals("+"))
            //{
            //    Program.addition(Fnum, Snum);
            //}
            //else if (sign.Equals("-"))
            //{
            //    Program.substraction(Fnum, Snum);
            //}
            //else if (sign.Equals("*"))
            //{
            //    Program.multiplication(Fnum, Snum);
            //}
            //else if (sign.Equals("/"))
            //{
            //    Program.division(Fnum, Snum);
            //}
            //else
            //{
            //    Console.WriteLine("entre correct value and signs");
            //}

            Console.WriteLine("Enter your roll number");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name");
            string names = Console.ReadLine();

            Console.WriteLine("Enter your  age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Batch");
            string batchs = Console.ReadLine();



            Program imran=new Program();
            imran.settdata(roll, names, age, batchs);
            imran.getdata();
            



                Console.ReadKey();

        }


        int rollno;
        string namee;
        int age;
        string batch;

        public void settdata(int rollnum,string stname,int stAge,string stBatch)
        {
            this.rollno = rollnum;
            this.namee = stname;
            this.age = stAge;
            this.batch = stBatch;

        }
        public void getdata()
        {
            Console.WriteLine("your roll number number is {0}",this.rollno);
            Console.WriteLine("your name  is {0}", this.namee);
            Console.WriteLine("your age  is {0}", this.age);
            Console.WriteLine("your batch is {0}", this.batch);

        }

        public void java()
        {
            Console.WriteLine("java");
        }

        public static void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Sum of {0} and {1} are:{2}",num1 ,num2,result);
        }

        public void name(string fname, string lname)
        {
            string fullName = fname + lname;
            Console.WriteLine("your full name is " + fullName);
        }

        public static void showAgeName(string name,int age)
        {
            Console.WriteLine("your name is "+name);
            Console.WriteLine("your age is " + age);

        }
        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is " + result);

        }
        public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("substraction result is " + result);

        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplication result is " + result);

        }
        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("division result is " + result);

        }
    }
}
