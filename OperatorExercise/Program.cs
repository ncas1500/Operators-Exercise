namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Created two integer variables called a and b.
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            int quotient = a / b;
            int remainder = a % b;

            
            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient}  remainder {remainder}");
              

        }
       
    }
}
