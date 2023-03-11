using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
   public class CalculateLength
    {
        int x1,x2,y1,y2;
        public CalculateLength(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double Calculate()
        {
            double result=Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            Console.WriteLine(result);
            return result;
        }
        public void CheckEquality(double line1, double line2)
        {
            if (line1.Equals(line2))
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }
        public void CopareLines(double line1,double line2)
        {
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both the lines are equal");
                if (line1.CompareTo(line2) > 0)
                    Console.WriteLine("line1 is greater than line2");
                else
                    Console.WriteLine("line2 is greater than line1");
            }
        }
    }
}
