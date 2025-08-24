using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exercise_2
{
    internal class Ex_01
    {
        /// <summary>
        /// Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            ex_1_1();
            ex_1_2();
            ex_1_3();
            ex_2_1();
            ex_2_2();
            ex_2_3();
            ex_2_4();
            ex_2_5();
        }
        static void ex_1_1()
        {
            //kelvin = celsius + 273
            //fahrenheit = celsius x 18 / 10 + 32
            Console.Write("Enter celsius: ");
            string input = Console.ReadLine();
            float celsius;
            while (!float.TryParse(input, out celsius))
            {
                Console.WriteLine("Invalid input. Please enter a number for celsius: ");
                input = Console.ReadLine();
            }   
            double kelvin = celsius + 273;
            double fahrenheit = celsius * (18 / 10) + 32;

            Console.WriteLine($"\tkelvin = {kelvin}\n" +
                $"\tfahrenheit= {fahrenheit}");
        }
        /// <summary>
        /// Create a program in C# for calculate the surface and volume of a sphere, given its radius.
        /// </summary>
        /// <param name="args"></param>
        static void ex_1_2()
        {

            //float radius = 0f;
            Console.Write("Enter radius: ");
            string input = Console.ReadLine();
            float radius;
            while (!float.TryParse(input, out radius))
            {
                Console.WriteLine("Invalid input. Please enter a number for radius: ");
                input = Console.ReadLine();
            }
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine($"\tSphere with radius = {radius}:\n" +
                $"\tsurface = {surface}\n" +
                $"\tvolume = {volume}");
        }
        /// <summary>
        /// Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
        /// </summary>
        /// <param name="args"></param>
        static void ex_1_3()
        {
            Console.Write("Enter first number: ");
            string input = Console.ReadLine();
            float firstnum;
            while (!float.TryParse(input, out firstnum))
            {
                Console.WriteLine("Invalid input. Please enter a number for first number: ");
                input = Console.ReadLine();
            }
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            float secondnum;    
            while (!float.TryParse(input2, out secondnum))
            {
                Console.WriteLine("Invalid input. Please enter a number for second number: ");
                input2 = Console.ReadLine();
            }
            float sum = firstnum + secondnum;
            float sub = firstnum - secondnum;
            float mul = firstnum * secondnum;
            float div = firstnum / secondnum;
            float mod = firstnum % secondnum;
            Console.WriteLine($"{firstnum} + {secondnum} = {sum}\n" +
                $"\t{firstnum} - {secondnum} = {sub}\n" +
                $"\t{firstnum} x {secondnum} = {mul}\n" +
                $"\t{firstnum} / {secondnum} = {div}\n" +
                $"\t{firstnum} mod {secondnum} = {mod}");
        }
        /// <summary>
        /// 1.Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,/,%) on them and displays the result of that operation.
        /// </summary>
        static void ex_2_1()
        {
            // Nhập số thứ nhất
            Console.Write("Enter first number: ");
            string input = Console.ReadLine();
            double num1;
            while (!double.TryParse(input, out num1))
            {
                Console.Write("Invalid input. Please enter a number for first number: ");
                input = Console.ReadLine();
            }

            // Nhập số thứ hai
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            double num2;
            while (!double.TryParse(input2, out num2))
            {
                Console.Write("Invalid input. Please enter a number for second number: ");
                input2 = Console.ReadLine();
            }

            // Nhập phép toán
            Console.Write("Enter an operation (+, -, *, /, %): ");
            string op = Console.ReadLine();
            while (string.IsNullOrEmpty(op) || "+-*/%".IndexOf(op) == -1)
            {
                Console.Write("Invalid operation. Please enter (+, -, *, /, %): ");
                op = Console.ReadLine();
            }
            char operation = op[0];
           
            double result = 0;
            bool valid = true;
            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: cannot divide by 0.");
                    valid = false;
                }
            }
            else if (operation == '%')
            {
                if (num2 != 0)
                    result = num1 % num2;
                else
                {
                    Console.WriteLine("Error: cannot mod by 0.");
                    valid = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation!");
                valid = false;
            }

            if (valid)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
        }
        /// <summary>
        /// 2.Write a C# Sharp program to display certain values of the function
        /// y^2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        static void ex_2_2()
        {
            Console.WriteLine("Value of the function x = y^2 + 2y + 1 (for y from -5 to 5):");

            for (int y = -5; y <= 5; y++)
            {
                int result = y * y + 2 * y + 1;  
                Console.WriteLine($"y = {y}, f(y) = {result}");
            }
        }
        /// <summary>   
        /// 3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        /// </summary>
        static void ex_2_3()
        {
            // Nhập quãng đường
            Console.Write("Enter distance (km): ");
            string input = Console.ReadLine();
            double distance;
            while (!double.TryParse(input, out distance) || distance < 0)
            {
                Console.Write("Invalid input. Please enter a number for distance (km): ");
                input = Console.ReadLine();
            }

            // Nhập thời gian
            Console.Write("Enter hours: ");
            string inputHours = Console.ReadLine();
            int hours;
            while (!int.TryParse(inputHours, out hours) || hours < 0)
            {
                Console.Write("Invalid input. Please enter a number for hours (>0): ");
                inputHours = Console.ReadLine();
            }

            Console.Write("Enter minutes: ");
            string inputMinutes = Console.ReadLine();
            int minutes;
            while (!int.TryParse(inputMinutes, out minutes) || minutes < 0 )
            {
                Console.Write("Invalid input. Please enter a number for minutes (>0): ");
                inputMinutes = Console.ReadLine();
            }

            Console.Write("Enter seconds: ");
            string inputSeconds = Console.ReadLine();
            int seconds;
            while (!int.TryParse(inputSeconds, out seconds) || seconds < 0 )
            {
                Console.Write("Invalid input. Please enter a number for seconds (>0): ");
                inputSeconds = Console.ReadLine();
            }

            // Đổi toàn bộ thời gian về giờ
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            if (totalTimeHours > 0)
            {
                // Tính vận tốc
                double speedKmh = distance / totalTimeHours;
                double speedMph = speedKmh * 0.621371;

                Console.WriteLine("\n- Result:\n" + 
                    $"+ SpeedKmh: {speedKmh} km/h\n" +
                    $"+ SpeedMph: {speedMph} miles/h");
            }
            else
            {
                Console.WriteLine("Error: Time must be greater than 0!");
            }
        }
        /// <summary>
        /// 4.Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
        /// </summary>
        static void ex_2_4()
        {
            // Nhập bán kính
            Console.Write("Enter radius (m): ");
            string input = Console.ReadLine();
            double r;
            while (!double.TryParse(input, out r) || r < 0)
            {
                Console.Write("Invalid input. Please enter a number for radius: ");
                input = Console.ReadLine();
            }

            // Tính diện tích bề mặt
            double surface = 4 * Math.PI * r * r;

            // Tính thể tích
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

            // Hiển thị kết quả
            Console.WriteLine($"Surface (m^2) = {surface}\n"+
                $"Volume (m^3) = {volume}");
        }
        /// <summary>
        /// 5.Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        static void ex_2_5()
        {
            Console.Write("Enter a character: ");
            string input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.Write("Invalid input. Please enter exactly ONE character: ");
                input = Console.ReadLine();
            }

            char ch = input[0];

            // Kiểm tra nguyên âm (a, e, i, o, u - cả hoa và thường)
            if ("aeiouAEIOU".IndexOf(ch) >= 0)
            {
                Console.WriteLine("This is a vowel.");
            }
            // Kiểm tra chữ số
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("This is a number.");
            }
            // Các ký tự còn lại
            else
            {
                Console.WriteLine("This is another symbol.");
            }
        }
    }
}
