using System;

namespace assignment_3
{
    class Person
    {
        public string Name;
    }


    internal class program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("enter any number: ");
            //int number =Convert.ToInt16 (Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"the number is : {number}"); 
            #endregion

            #region Q2
            //Console.Write("enter any number: ");
            //int number = Convert.ToInt16(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"the number is : {number}");
            //it will give an exception bec it can't happen(System.FormatException: 'The input string 'asd' was not in a correct format.' 
            #endregion

            #region Q3

            //float a = 1.23f , b=2.5f;

            //Console.WriteLine($"result of a+b is : {a+b}");
            //Console.WriteLine($"result of a*b is : {a * b}");
            //Console.WriteLine($"result of a-b is : {a - b}");
            //Console.WriteLine($"result of a/b is : {a / b}"); 
            #endregion


            #region Q4 
            //string name = "mohamed gamal";
            //string Result=name.Substring(3)
            //Console.WriteLine($"The name is: {Result}"); 
            #endregion

            #region Q5

            //int a = 100;
            //long b = a; // implicit conversion from int to long
            //Console.WriteLine($"The value of b is: {b}"); // Output: The value of b is: 100

            //long c = 10000L;
            //int d = (int)c; // explicit conversion from long to int
            //Console.WriteLine($"The value of d is: {d}"); // Output: The value of d is: 10000

            #endregion

            #region q6
            //Person person1 = new Person();
            //person1.Name = "Mohamed";

            //Person person2 = person1; 

            //person2.Name = "Gamal";   
            //Console.WriteLine("person1.Name: " + person1.Name);
            //Console.WriteLine("person2.Name: " + person2.Name);


            #endregion

            #region q7
            //string fname = "mohamed";
            //string lname = "gamal";
            //Console.WriteLine($"{fname+lname}");

            #endregion

            #region Q8
            //int interest, pricipal_amount, rate, time;
            //Console.Write("enter your principal amount: ");
            //pricipal_amount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your rate: ");
            //rate = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your time: ");
            //time = Convert.ToInt32(Console.ReadLine());
            //interest = (pricipal_amount * rate * time) / 100;
            //Console.Clear();
            //Console.WriteLine($"the interest is : {interest}"); 
            #endregion

            #region Q9
            //int BMI, Weight, height;
            //Console.Write("enter your weight amount: ");
            //Weight = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your height: ");
            //height = Convert.ToInt32(Console.ReadLine());
            //BMI = Weight / (height * height);

            //Console.Clear();
            //Console.WriteLine($"your BMI is : {BMI}"); 
            #endregion

            #region Q10
            //int temp, x = 10, y = 30;
            //Console.Write("enter your temp: ");
            //temp = Convert.ToInt32(Console.ReadLine());
            //string    result =temp<x  ?"justcold" : temp > y ? "just hot" : "justgood";

            //Console.Clear();
            //Console.WriteLine($"the result is : {result}");
            #endregion

            #region Q11
            //int day, month, year;
            //Console.Write("enter your day: ");
            //day = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your month: ");
            //month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your year: ");
            //year = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"{day},{month},{year}");

            #endregion

            #region Q12
            //int x;
            //Console.Write("enter your number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //if (x % 3==0 && x % 4==0)
            //{
            //    Console.WriteLine("yes");

            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region Q13
            //int x;
            //Console.Write("enter your number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //if(x==0)
            //{
            //    Console.WriteLine("zero");
            //}
            //else if (x>0)
            //{ Console.WriteLine("positive");
            //}
            //else
            //{ Console.WriteLine("negative"); }
            #endregion
            #region Q14
            //int x, y, z;
            //Console.Write("enter your first number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your seconed number: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter your third number: ");
            //z = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //if (x > y && x > z)
            //{
            //    Console.WriteLine($"the max element is : {x}");
            //}
            //else if (y > x && y > z)
            //{
            //    Console.WriteLine($"the max element is : {y}");
            //}
            //else
            //{
            //    Console.WriteLine($"the max element is : {z}");
            //}
            //if (x < y && x < z)
            //{
            //    Console.WriteLine($"the min element is : {x}");
            //}
            //else if (y < x && y < z)
            //{
            //    Console.WriteLine($"the max element is : {y}");
            //}
            //else
            //{
            //    Console.WriteLine($"the max element is : {z}");
            //}

            #endregion

            #region Q15
            //int x;
            //Console.Write("enter your number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //if(x% 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}

            #endregion
        }


    }
}


