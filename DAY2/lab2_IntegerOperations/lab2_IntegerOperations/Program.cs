namespace lab2_IntegerOperations
{
    internal class Program
    {
        public static int enterNumber()
        {
            int tmp;
            Console.WriteLine("Enter Number: ");
            tmp = int.Parse(Console.ReadLine());
            return tmp;
        }
        static void Main(string[] args)
        {
            int a, b, c, d;
            int sum;
            double divide, mul;
            a = enterNumber();
            b = enterNumber();
            c = enterNumber();
            d = enterNumber();

            sum = a + b;
            divide = sum / c;
            mul = divide * d;
            Console.WriteLine(mul);
        }
    }
}