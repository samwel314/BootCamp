using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BootCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(SortString("dcba"));


         
   
          
        }
        // ----------------------------  Part 1   ------------------------
        // 1 
        public static int Sum(int x, int y)
        {
            return x == y ? (x + y) * 3 : (x + y);
        }

        // 2 
        public static int Absolutedifference(int n)
        {
            // return n > 51 ? (n - 51) * 3 :  Math.Abs(n - 51); 

            return n > 51 ? (n - 51) * 3 : 51 - n;
        }
        // 3 
        public static bool CheckIntegers(int x, int y)
        {
            if (x == 30 || y == 30 || (x + y) == 30)
                return true;

            return false;

        }

        // 4 
        public static bool CheckWithin(int n)
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
                return true;
            return false;
        }
        //5 

        public static string CreateString(string value)
        {
            if (value.StartsWith("if"))
                return value;
            // return string.Concat("if ", value); 
            return $"if {value}";
        }


        // 6 
        public static string RemoveCharacter(string value, int position)
        {
            if (position > value.Length - 1 || position < 0)
                return value;

            return value.Remove(position, 1);
        }

        //7 

        public static string Exchange(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 1)
                return value;

            return $"{value[value.Length - 1]}{value.Substring(1, value.Length - 2)}{value[0]}";
        }

        //8 
        public static string String4Copies(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 1)
                return value;

            //
            StringBuilder newValue = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                newValue.Append(value.Substring(0, 2));
            }

            return newValue.ToString();
        }

        // 9 

        public static string LastChar(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            return $"{value[value.Length - 1]}{value}{value[value.Length - 1]}";
        }



        // 10 

        public static bool Multiple3or7(int n)
        {
            if (n % 3 == 0 || n % 7 == 0)
                return true;

            return false;
        }


        // 11 
        public static string Taking3Char(string value)
        {

            if (string.IsNullOrEmpty(value) || value.Length < 3)
                return value;


            return $"{value.Substring(0, 3)}{value}{value.Substring(0, 3)}";
        }


        // 12 

        public static bool CheckString(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            return value.StartsWith("C#");
        }

        // 13 


        public static bool CheckTemperature(int t1, int t2)
        {
            if (t1 < 0 && t2 > 0)
                return true;

            if (t2 < 0 && t1 > 0)
                return true;


            return false;

        }


        //14

        public static bool CheckRange(int n1, int n2)
        {
            if ((n1 >= 100 && n1 <= 200) && (n2 >= 100 && n2 <= 200))
                return true;
            return false;
        }

        //15 
        public static bool CheckRange(int n1, int n2, int n3)
        {
            if ((n1 >= 20 && n1 <= 50) || (n2 >= 20 && n2 <= 50) || (n3 >= 20 && n3 <= 50))
                return true;
            return false;
        }

        //16

        public static bool CheckRange16(int n1, int n2)
        {
            if ((n1 >= 20 && n1 <= 50) && !(n2 >= 20 && n2 <= 50))
                return true;
            if (!(n1 >= 20 && n1 <= 50) && (n2 >= 20 && n2 <= 50))
                return true;


            return false;
        }
        // 17 

        public static string CheckAppears(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3)  // yt 1
                return value;

            if (value[1] == 'y' && value[2] == 't')
                return value.Remove(1, 2);

            return value;
        }

        // 18 

        public static int Largest(int n1, int n2, int n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }

        // 19 

        public static int MoreClosest(int n1, int n2)
        {
            if (n1 == n2)
                return 0;


            var abs1 = Math.Abs(100 - n1);
            var abs2 = Math.Abs(100 - n2);
            return abs1 < abs2 ? n1 : n2;
        }

        // 20 

        public static bool CheckRange20(int n1, int n2)
        {
            if ((n1 >= 40 && n1 <= 50) && (n2 >= 40 && n2 <= 50))
                return true;

            if ((n1 >= 50 && n1 <= 60) && (n2 >= 50 && n2 <= 60))
                return true;

            return false;
        }

        // 21 
        public static int CheckRange21(int n1, int n2)
        {
            if ((n1 >= 20 && n1 <= 30) && (n2 >= 20 && n2 <= 30))
                return n1 >= n2 ? n1 : n2;

            return 0;
        }
        // 22 
        public static bool CountZ(string value)
        {
            int Count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == 'z')
                    Count++;
            }

            return (Count >= 2) && (Count <= 4) ? true : false;
        }

        // 23 
        public static bool SameLastDigit(int n1, int n2)
        {
            var digit1 = n1 % 10;
            var digit2 = n2 % 10;

            return digit1 == digit2;
        }


        // 24 

        public static string Last3Uppercase(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            if (value.Length < 3)
                return value.ToUpper();
            // Python  // 6 6-1-3
            var v = value.Substring(0, value.Length - 3);
            return $"{v}{value.Substring(value.Length - 3, 3).ToUpper()}";

        }


        //25 
        public static string CopiesByN(string value, int n)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            if (n <= 1)
                return value;

            StringBuilder builder = new StringBuilder(value);

            for (int i = 0; i < n - 1; i++)
            {
                builder.Append(value);
            }
            return builder.ToString();
        }

        // ----------------------------  Part 2   ------------------------
        // 1 

        public static void AcceptTwo()
        {
            int number1 = 0;
            int number2 = 0;
            while (true)
            {
                Console.WriteLine("Enter N1 ");
                var value = Console.ReadLine();



                if (int.TryParse(value, out number1))
                    break;
                else
                    Console.WriteLine($"{value} Not Number '");
            }
            while (true)
            {
                Console.WriteLine("Enter N2 ");
                var value = Console.ReadLine();



                if (int.TryParse(value, out number2))
                    break;
                else
                    Console.WriteLine($"{value} Not Number '");
            }

            if (number1 == number2)
                Console.WriteLine($"{number1} and {number2} are equal");
            else
                Console.WriteLine($"{number1} and {number2} are Not  equal");
        }
        // 2 
        public static string CheckOddOrEven(int n)
        {
            if (n % 2 == 0)
                return $"{n} is Even  ";
            else
                return $"{n} is Odd  ";

        }

        // 3 
        public static string CheckPositiveOrNegative(int n)
        {
            if (n > 0)
                return $"{n} is Positive  ";
            else if (n < 0)
                return $"{n} is Negative  ";
            else
                return "This Zero neither negative nor positive ";

        }

        //  4 
        public static string LeepYear(int year)
        {
            if (year % 4 == 0)
                return $"{year} is a leap year";
            else
                return $"{year} is not  a leap year";
        }

        // 5 

        public static void CheckAge()
        {

            int age = 0;
            while (true)
            {
                Console.WriteLine("Enter Your Age  ");
                var value = Console.ReadLine();



                if (int.TryParse(value, out age))
                    break;
                else
                    Console.WriteLine($"{value} invalid age  '");
            }
            if (age >= 21)
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine("Sorry !  You are  not eligible for casting your vote.");

        }


        // 6 

        public static void ReadM()
        {

            int m = 0;
            while (true)
            {
                Console.WriteLine("Enter Number   ");
                var value = Console.ReadLine();



                if (int.TryParse(value, out m))
                    break;
                else
                    Console.WriteLine($"{value} invalid Number   '");
            }
            if (m > 0)
                Console.WriteLine($"The value of n = {1}");
            else if (m < 0)
                Console.WriteLine($"The value of n = {-1}");
            else
                Console.WriteLine($"The value of n = {0}");
        }


        // 7 

        public static string CheckHeight(int height)
        {
            if (height <= 147)
                return "The person is Dwarf";

            if (height >= 152 && height <= 163)
                return "The person is Short";

            if (height >= 191)
                return "The person is Very Tall";



            return "The person is Normal ";

        }


        //  8 

        public static void LargestOf3()
        {

            // read 
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            while (true)
            {
                Console.WriteLine("Enter N1 ");
                var value = Console.ReadLine();

                if (int.TryParse(value, out number1))
                    break;
                else
                    Console.WriteLine($"{value} Not Number '");
            }

            while (true)
            {
                Console.WriteLine("Enter N2 ");
                var value = Console.ReadLine();



                if (int.TryParse(value, out number2))
                    break;
                else
                    Console.WriteLine($"{value} Not Number '");
            }
            while (true)
            {
                Console.WriteLine("Enter N3 ");
                var value = Console.ReadLine();



                if (int.TryParse(value, out number2))
                    break;
                else
                    Console.WriteLine($"{value} Not Number '");
            }


            //
            var max = Math.Max(number1, Math.Max(number2, number3));

            if (max == number1)
                Console.WriteLine("The 1nd Number is the greatest among three");
            else if (max == number2)
                Console.WriteLine("The 2nd Number is the greatest among three");
            else
                Console.WriteLine("The 3nd Number is the greatest among three");

        }

        // 9 

        public static string CheckQuadrant(int x, int y)
        {
            if (x >= 0 && y >= 0)
                return "One Quadrant ";

            if (x < 0 && y < 0)
                return "There Quadrant ";

            if (x >= 0 && y < 0)
                return "Four  Quadrant ";


            return "Two  Quadrant ";  // --*


        }

        //10 *****

        public static string DetermineEligibility(int math, int phy, int chem)
        {
            if ((math >= 65 && phy >= 55 &&
                chem >= 50 && (math + phy + chem) >= 180) || (math >= 65 && (phy + chem) >= 140))
            {
                return "The candidate is eligible for admission.";
            }

            return "The candidate is not   eligible for admission.";
        }


        // 11 


        // ax^2 + bx + c = 0 

        //
        public static string CalculateQuadratic(int a, int b, int c)
        {

            // NAN
            var pw = Math.Pow(b, 2) - (4 * a * c);  // 0 one root ,            > two            < no roots 
            var root1 = ((-1 * b) + Math.Sqrt(pw)) / (a * 2);
            var root2 = ((-1 * b) - Math.Sqrt(pw)) / (a * 2);

            if (double.IsNaN(root2) && double.IsNaN(root1))
                return "Root are imaginary";

            // !f  = >  t 
            if (!double.IsNaN(root2) && double.IsNaN(root1))
                return $"the real root is {root2}";

            if (double.IsNaN(root2) && !double.IsNaN(root1))
                return $"the real root is {root1}";

            return $"the real roots  is {root1}    and   {root2} ";

        }



        //15 

        public static string Triangle(int a, int b, int c)
        {
            return (a + b + c) == 180 ? "Yes" : "No";
        }


        /////////// ------------------------------------------------ part 3 ------------------------------------------------**-

        //1
        public static void PrintString()
        {
            Console.WriteLine("Input the string :");
            var str = Console.ReadLine();

            Console.WriteLine($"The string you entered is : {str}");
        }


        // 2 

        public static int Strlength(string value)
        {
            var len = 0;
            foreach (char c in value)
                len++;


            return len;

        }



        // 3 

        public static void SeparateIndividual(string value)
        {

            foreach (char c in value)
                Console.Write($"{c} ");

            Console.WriteLine();
        }

        // 4 

        public static void ReverseOrder(string value)
        {

            //can use 
            //for (int i = value.Length - 1; i >= 0; i--)
            //    Console.Write(value[i]);
            // or 
            foreach (var c in value.Reverse())
            {
                Console.Write(c); 
            }
        }


        //5 

        public static int  TotalNumberOfWords (string value )
        {
            return value.Split(" ").Length; 
        }



        // 6 

        public static bool Compare (string value1 , string value2 )
        {
            if (string.IsNullOrEmpty(value1) || string.IsNullOrEmpty(value2)) 
                return false;

            if (value1.Length != value2.Length)
                return false;   

            for (int i = 0;  i < value1.Length; i++)
            {
                if (value1[i] != value2[i])     
                    return false;
            }

            return true;    
        }

        // 7 

        public static string CountTheNumberOf(string value )
        {
            int digits = 0;
            int alphabets = 0;
            int special = 0; 
            foreach (var c in value)
            {
                if (char.IsDigit(c))
                    digits++;
                else if (char.IsLetter(c))
                    alphabets++;
                else
                    special++; 
            }

            return $"[ Alphabets  = {alphabets} ] [ Digits = {digits} ] [ special = {special} ] "; 
        }
        // 8 


        public static string CopyString (string value )
        {
            return new string(value);
        }

        // 9 

        public static string NumberOfVowels (string value )
        {
            var Vowels = new List<char>() { 'a' , 'e' , 'i' , 'o' , 'y'};

            var v = 0; 
            foreach (var ch  in value.ToLower())
            {
                
              if (Vowels.Contains(ch))
                {
                    v++;
                    Console.Write(ch);  
                }

            }

            return $"Vowels = {v}  , consonant = {value.Length - v}"; 
        }


        // 10 

        public static string Frequency (string value )
        {
            //Dictionary<char , int> pairs = new Dictionary<char , int>();        

            //foreach (var ch in value.ToLower())
            //{
            //    if (pairs.ContainsKey(ch))
            //    {
            //        pairs[ch]++;    
            //    }
            //    else
            //    {
            //        pairs[ch] = 1;  
            //    }
            //}

            //var count = 0;

            //var v = 's'; 

            //foreach (var pair in pairs) 
            //{
            //    if (pair.Value >= count)
            //    {
            //        count = pair.Value; 
            //        v = pair.Key;  
            //    }
            //}
            //return $"{v}  =  {count}"; 


            var g = value.GroupBy(c => c).Select(g => new
            {
                count = g.Count(),
                key = g.Key,
            }).OrderByDescending(g => g.count).First();

           return $"{g.key}  =  {g.count}";  

        }


        //11

        public static string SortString (string value )
        {
            StringBuilder builder   = new StringBuilder(value);  

            for (int i = 0; i < builder.Length ; i++)
            {

                int index = i;
                char c = builder[i];
                for (int j = 0 ; j  < builder.Length - i ; j++) 
                {
                    if (c > builder[j])
                    {

                        builder[index] = builder[j];

                        builder[j] = c;
                        index = j; 
                    }
                }   
            }
            return builder.ToString();  
        }

    }



}
