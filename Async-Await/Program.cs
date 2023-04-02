using static Async_Await.Tasks;

namespace Async_Await;
class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            int[] arr = await TenRandomIntsAsync();
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", arr));

            arr = await MultiplyRandomArrayAsync(arr);
            Console.WriteLine("Multiplied array:");
            Console.WriteLine(string.Join(", ", arr));

            arr = await SortAscendingAsync(arr);
            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", arr));

            double avg = await GetAverageValueAsync(arr);
            Console.WriteLine($"Average value: {avg}");
        }
        catch (AggregateException ex)
        {
            Console.WriteLine("An acception has occured: " + ex.Message);
        }

        Console.ReadKey();
    }
}

