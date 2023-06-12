namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program completed.");
            }
        }

        public static void StartSequence()
        {
            Console.WriteLine("Please enter a number greater than 0");
            string number = Console.ReadLine();
            int convertedNumber = Convert.ToInt32(number);

            int[] arraySize = new int[convertedNumber];

            Populate(arraySize);

            int sum = GetSum(arraySize);
            int product = GetProduct(arraySize);
            Console.WriteLine("enter a number to divide the array on");
            string DividedNumber = Console.ReadLine();
            int converted = Convert.ToInt32(DividedNumber);
            int quotient = GetQuotient(product, converted);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }

        public static void Populate(int[] array)
        {


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Please enter the value for the array at index {i}");
                string inputValue = Console.ReadLine();
                array[i] = Convert.ToInt32(inputValue);
            }
        }

        static int GetSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            return sum;
        }

        static int GetProduct(int[] array)
        {
            int product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product = product * array[i];
            }

            return product;
        }

        static int GetQuotient(int product, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            int quotient = product / divisor;

            return quotient;
        }
    }
}