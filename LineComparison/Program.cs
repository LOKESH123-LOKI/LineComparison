using System;
namespace LineComparison
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineCompoarison");
            Console.WriteLine("Enter x1");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2");
            int x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int y2=Convert.ToInt32(Console.ReadLine());
            CalculateLength calculateLength=new CalculateLength(x1,x2,y1,y2);
            calculateLength.Calculate();
        }
    }
}