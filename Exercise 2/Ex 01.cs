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
            ex_1_3();
        }
        static void ex_1_1()
        {
            //kelvin = celsius + 273
            //fahrenheit = celsius x 18 / 10 + 32
            Console.Write("Enter celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenheit = celsius * (18 / 10) + 32;

            Console.WriteLine($"{celsius} celsius = {kelvin} kelvin\n" +
                $"\t {celsius} celsius = {fahrenheit} fahrenheit");
        }
        /// <summary>
        /// Create a program in C# for calculate the surface and volume of a sphere, given its radius.
        /// </summary>
        /// <param name="args"></param>
        static void ex_1_2()
        {

            //float radius = 0f;
            Console.Write("Enter radius: ");
            float radius = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine($"Sphere with radius = {radius}:\n" +
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
            float firstnum = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            float secondnum = float.Parse(Console.ReadLine());
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
            Console.Write("Nhập số thứ nhất: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Nhập số thứ hai
            Console.Write("Nhập số thứ hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Nhập phép toán
            Console.Write("Nhập phép toán (+, -, *, /, %): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Lỗi: không thể chia cho 0.");
                        valid = false;
                    }
                    break;
                case '%':
                    if (num2 != 0)
                        result = num1 % num2;
                    else
                    {
                        Console.WriteLine("Lỗi: không thể lấy dư với 0.");
                        valid = false;
                    }
                    break;
                default:
                    Console.WriteLine("Phép toán không hợp lệ!");
                    valid = false;
                    break;
            }

            if (valid)
            {
                Console.WriteLine($"Kết quả: {num1} {operation} {num2} = {result}");
            }
        }
        /// <summary>
        /// 2.Write a C# Sharp program to display certain values of the function
        /// y^2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        static void ex_2_2()
        {
            Console.WriteLine("Giá trị của hàm x = y^2 + 2y + 1 (y từ -5 đến 5):");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("   y\t|\t x");
            Console.WriteLine("-----------------------------------------------");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;  // công thức x = y^2 + 2y + 1
                Console.WriteLine($"  {y}\t|\t {x}");
            }
        }
        /// <summary>   
        /// 3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        /// </summary>
        static void ex_2_3()
        {
            // Nhập quãng đường
            Console.Write("Nhập quãng đường (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Nhập thời gian
            Console.Write("Nhập số giờ: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số phút: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số giây: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // Đổi toàn bộ thời gian về giờ
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            if (totalTimeHours > 0)
            {
                // Tính vận tốc
                double speedKmh = distance / totalTimeHours;
                double speedMph = speedKmh * 0.621371;

                Console.WriteLine("\n--- KẾT QUẢ ---");
                Console.WriteLine($"Vận tốc: {speedKmh:F2} km/h");
                Console.WriteLine($"Vận tốc: {speedMph:F2} miles/h");
            }
            else
            {
                Console.WriteLine("Thời gian phải lớn hơn 0!");
            }
        }
        /// <summary>
        /// 4.Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
        /// </summary>
        static void ex_2_4()
        {
            // Nhập bán kính
            Console.Write("Nhập bán kính hình cầu: ");
            double r = Convert.ToDouble(Console.ReadLine());

            // Tính diện tích bề mặt
            double surface = 4 * Math.PI * r * r;

            // Tính thể tích
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

            // Hiển thị kết quả
            Console.WriteLine("\n--- KẾT QUẢ ---");
            Console.WriteLine($"Diện tích bề mặt = {surface:F2}");
            Console.WriteLine($"Thể tích = {volume:F2}");
        }
        /// <summary>
        /// 5.Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        static void ex_2_5()
        {
            Console.Write("Nhập một ký tự: ");
            char ch = Convert.ToChar(Console.ReadLine());

            // Kiểm tra nguyên âm (a, e, i, o, u - cả hoa và thường)
            if ("aeiouAEIOU".IndexOf(ch) >= 0)
            {
                Console.WriteLine("Đây là nguyên âm.");
            }
            // Kiểm tra chữ số
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Đây là chữ số.");
            }
            // Các ký tự còn lại
            else
            {
                Console.WriteLine("Đây là ký tự khác (symbol).");
            }
        }
    }
