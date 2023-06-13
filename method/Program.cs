using System.Security.Cryptography.X509Certificates;

namespace method
{
    public class Programs
    {
        public static void methodSqrt(int num)
        {
            var sqr = Math.Sqrt(num);
            Console.WriteLine(sqr);
        }
        public static void methodPow(int num, int numTwo)
        {
            var sqr = Math.Pow(num, numTwo);
            Console.WriteLine(sqr);
        }
        public static string userFullName(string fName, string lName)
        {
            var fullName = fName + " " + lName;
            return fullName;
        }
    }
}
