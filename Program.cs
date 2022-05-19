using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = { 2, 4, 6, 9 };
            bool oddNumber = false;
            foreach (int num in arrayNum)
            {
                if (num %2 == 0)
                {
                    oddNumber = true;
                    break;
                }
            }
            if (oddNumber)
            {
                Console.WriteLine("There is an odd number in the array");
            } else
            {
                Console.WriteLine("There is no odd number in the array.");
            }
        }
            
      
        
    }
}
