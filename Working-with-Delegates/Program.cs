namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate double Product(double a, double b);
        static double GetSum(double x, double y)
        {
            return x + y;
        }
        static double GetProduct(double a, double b)
        {
            return a * b;
        }
        static void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            MathSolutions solutions = new MathSolutions();

            Func<double, double, double> sum = GetSum;
            Console.WriteLine(sum(num1, num2));

            Product p = new Product(MathSolutions.GetProduct);
            Console.WriteLine(p(num1, num2));

            Action<double, double> a = GetSmaller;
            a(num1, num2);
        }
    }
}