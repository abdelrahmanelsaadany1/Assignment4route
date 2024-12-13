namespace answers
{
    class Person
    {
        public string Name;
    }
    internal class Program
    {
        #region are points collinear function 
        //static bool ArePointsCollinear(int x1, int y1, int x2, int y2, int x3, int y3)
        //{
        //    int determinant = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
        //    return determinant == 0;
        //}

        #endregion

        #region modify by value
        //static void ModifyByValue(int num)
        //{
        //    num = 100; // Modify the copy, not the original
        //}
        #endregion
        #region modify by reference
        //static void ModifyByReference(ref int num)
        //{
        //    num = 100; // Modify the original value
        //}
        #endregion
        #region modify by value q2
        //static void ModifyPersonByValue(Person p)
        //{
        //    p.Name = "ali";  
        //    p = new Person(); 
        //    p.Name = "mahmoud";   
        //}
        #endregion
        #region modify by reference q2
        //static void ModifyPersonByReference(ref Person p)
        //{
        //    p.Name = "ali";  
        //    p = new Person(); 
        //    p.Name = "mahmoud";  
        //}
        #endregion
        #region prime detector
        //static bool IsPrime(int number)
        //{

        //    if (number <= 1)
        //    {
        //        return false;
        //    }


        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;  
        //        }
        //    }

        //    return true;  
        //}
        #endregion
        #region Max and min in array
        //static void MinMaxArray(int[] array, ref int min, ref int max)
        //{
        //    min = array[0];  
        //    max = array[0];

            
        //    foreach (int num in array)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {

            #region q1
            //int[,] Points = new int[3, 2];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"please enter values for point{i + 1}");
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine($"please enter points {j+1}");
            //        Points[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int x1 = Points[0, 0], y1 = Points[0, 1];
            //int x2 = Points[1, 0], y2 = Points[1, 1];
            //int x3 = Points[2, 0], y3 = Points[2, 1];

            //// Check for collinearity using the determinant method
            //if (ArePointsCollinear(x1, y1, x2, y2, x3, y3))
            //{
            //    Console.WriteLine("The points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on the same straight line.");
            //}
            #endregion
            #region q2
            //Console.WriteLine("Enter the number of hours taken by the worker:");
            //string input = Console.ReadLine();

            //int hoursTaken;

            //if (int.TryParse(input, out hoursTaken))
            //{
            //    if (hoursTaken >= 2 && hoursTaken <= 3)
            //    {
            //        Console.WriteLine("The worker is highly efficient.");
            //    }
            //    else if (hoursTaken > 3 && hoursTaken <= 4)
            //    {
            //        Console.WriteLine("The worker is instructed to increase their speed.");
            //    }
            //    else if (hoursTaken > 4 && hoursTaken <= 5)
            //    {
            //        Console.WriteLine("The worker is provided with training to enhance their speed.");
            //    }
            //    else if (hoursTaken > 5)
            //    {
            //        Console.WriteLine("The worker is required to leave the company.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number of hours.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}


            #endregion
            #region q3
            //Console.Write("Enter the size of the matrix (n): ");
            //int n;


            //if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            //{

            //    for (int i = 0; i < n; i++)  
            //    {
            //        for (int j = 0; j < n; j++)  
            //        {

            //            Console.Write((i == j) ? "1 " : "0 ");  
            //        }
            //        Console.WriteLine(); 
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the matrix size.");
            //}
            #endregion
            #region 20
            //int[] Numbers =  {1,2,3};
            //int Sum = 0;
            //foreach (int num in Numbers) { 
            //Sum += num;
            //}
            //Console.WriteLine($"sum of numbers in array is = { Sum}");
            #endregion
            #region 21
            //int[] array1 = { 1, 3, 5, 7, 9 };
            //int[] array2 = { 2, 4, 6, 8, 10 };

            //int[] mergedArray = new int[array1.Length + array2.Length];


            //array1.CopyTo(mergedArray, 0);
            //array2.CopyTo(mergedArray, array1.Length);


            //Console.WriteLine("Merged Array:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion
            #region 22 
            // i dont know the answer
            #endregion
            #region 23
            //int[] array = { 1,2,3,4,5,6,18,1, };


            //int max = array[0];
            //int min = array[0];


            //foreach (int num in array)
            //{
            //    if (num > max)
            //    {
            //        max = num; 
            //    }
            //    if (num < min)
            //    {
            //        min = num; 
            //    }
            //}


            //Console.WriteLine("Maximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);

            #endregion
            #region 24
            //int[] array = {1,7,5,6,2 };

            //// Sort the array in descending order
            //Array.Sort(array);
            //Array.Reverse(array);


            //// Print the second largest element
            //Console.WriteLine("Second largest element: " + array[1]);
            #endregion
            #region 25
            // i donk know the answer
            #endregion
            #region 26

            //Console.WriteLine("Enter string you want to reverse:");
            //string input = Console.ReadLine();


            //string[] words = input.Split(' ');

            //Array.Reverse(words);

            //string output = string.Join(" ", words);

            //Console.WriteLine("Reversed string: " + output);
            #endregion
            #region 27
            //int[,] array1 = new int[2, 3];
            //int[,] array2 = new int[2, 3];


            //Console.WriteLine("Enter values for the first array:");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter value for array1[{i}, {j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}


            //Console.WriteLine(" The second array after copying the elements:");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 28
            //int[] array = { 1, 2, 3, 4, 5 };

            //// Print the array in reverse order
            //Console.WriteLine("Array in reverse order:");

            //for (int i = array.Length ; i > 0; i--)
            //{
            //    Console.Write(array[i-1] + " ");
            //}
            #endregion
            #region Functions
            #region  q1
            #region f1 by value 
            //int a = 10;
            //Console.WriteLine("Before passing by value: " + a);

            //ModifyByValue(a); // Pass by value

            //Console.WriteLine("After passing by value: " + a);
            #endregion
            #region f1 by reference
            //int b = 10;
            //Console.WriteLine("Before passing by reference: " + b);

            //ModifyByReference(ref b); // Pass by reference

            //Console.WriteLine("After passing by reference: " + b);
            #endregion
            #endregion
            #region q2
            // by value
            //Person person1 = new Person();
            //person1.Name = "Alice";

            //Console.WriteLine("Before passing by value: " + person1.Name);

            //ModifyPersonByValue(person1); 

            //Console.WriteLine("After passing by value: " + person1.Name);
            //// by reference
            //Person person2 = new Person();
            //person1.Name = "Alice";

            //Console.WriteLine("Before passing by reference: " + person2.Name);

            //ModifyPersonByReference(ref person2); 

            //Console.WriteLine("After passing by reference: " + person2.Name); 
            #endregion
            #region q3
            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the fourth number:");
            //int num4 = int.Parse(Console.ReadLine());


            //int sum = num1 + num2;
            //int difference = num3 - num4;


            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");
            #endregion
            #region q4
            // i dont know answer
            #endregion
            #region q5
            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());


            //if (IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion
            #region q6
            //int[] numbers = { 3, 5, 7, 2, 8, 1, 6 };

           
            //int min = 0, max = 0;

           
            //MinMaxArray(numbers, ref min, ref max);

           
            //Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion
            // i dont know last two questions
            #endregion
        }
    }
}
