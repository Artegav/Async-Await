namespace Async_Await
{
    public class Tasks
    {
        public static async Task<int[]> TenRandomIntsAsync()
        {
            return await Task.Run(() =>
            {
                var random = new Random();
                int[] ints = new int[10];

                for (int i = 0; i < ints.Length; i++)
                {
                    ints[i] = random.Next(1, 100);
                }

                Console.WriteLine("Creating an array with 10 random integers");
                Console.WriteLine(string.Join(", ", ints));

                return ints;
            });
        }

        public static async Task<int[]> MultiplyRandomArrayAsync(int[] prevArray)
        {
            return await Task.Run(() =>
            {
                var array = prevArray ?? throw new ArgumentNullException(nameof(prevArray), "The given array is null");
                var random = new Random();
                var number = random.Next(1, 11);

                for (int i = 0; i < array.Length; ++i)
                {
                    array[i] *= number;
                }

                Console.WriteLine($"Multiplying array by {number}");
                Console.WriteLine(string.Join(", ", array));

                return array;
            });
        }

        public static async Task<int[]> SortAscendingAsync(int[] prevArray)
        {
            return await Task.Run(() =>
            {
                var array = prevArray ?? throw new ArgumentNullException(nameof(prevArray), "The given array is null");
                Array.Sort(array);
                Console.WriteLine("Array is being sorted by ascending");
                Console.WriteLine(string.Join(", ", array));

                return array;
            });
        }

        public static async Task<double> GetAverageValueAsync(int[] prevArray)
        {
            return await Task.Run(() =>
            {
                var array = prevArray ?? throw new ArgumentNullException(nameof(prevArray), "The given array is null");
                double average = array.Average();
                Console.WriteLine($"Average value of the array: {average}");

                return average;
            });
        }
    }
}

