namespace Rekursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Låt oss prova ett att summera alla ints i en array");
            int[] integers = { 1, 4, 3, 5, 9, 1, 4, 9, 4, 7, 12, 5, 1, 64, 8, 543, 7, 5, 2, 87, 2, 5, 6 };
            //int sum = SumWithLoop(integers);
            //Console.WriteLine(sum);
            int recSum = SumWithRecursion(integers, integers.Length);
            //Console.WriteLine(recSum);
            int tail = TailRecursion(integers, 0, 0);
        }

        private static int TailRecursion(int[] integers, int sum, int index)
        {
            if (index == integers.Length)
            {
                return sum;
            }
            int current = integers[index] + sum;
            return TailRecursion(integers, current, index+1);                           
        }

        private static int SumWithRecursion(int[] integers, int size)
        {
            if (size == 0)
            {
                return 0;
            }
            return integers[size - 1] + SumWithRecursion(integers, size - 1);
        }

        private static int SumWithLoop(int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++) 
            {
                sum = sum + ints[i];
            }
            return sum;
        }
    }
}