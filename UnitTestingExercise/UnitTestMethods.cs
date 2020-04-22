using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int AddMethod(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            return sum;
        }
        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int SubtractMethod(int min1, int sub2)
        {
            int diff = min1 - sub2;
            return diff;
        }
        // Create a Multiply method that passes 2 integers
        public int MultiMethod(int num1, int num2)
        {
            int prod = num1 * num2;
            return prod;
        }
        // Create a Divide method that passes 2 integers\
        public int DivideMethod(int num1, int num2)
        {
            int quo = num1 / num2;
            return quo;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string FactorTest(int num1, int num2)
        {
            if(num1 % num2 == 0)
            {
                return "They factor into each other!";
            }
            else
            {
                return "They do not factor";
            }
        }
        public string EvenOrOdd(int num1)
        {
            if(num1 % 2 == 0)
            {
                return "It is even!";
            }
            else
            {
                return "It is odd";
            }
        }
        
    }
}
