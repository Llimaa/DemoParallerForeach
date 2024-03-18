
List<int> numbers =  [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];

await ParallelForeachAsync(numbers);

async Task ParallelForeachAsync(List<int> numbers)
{
    var options = new ParallelOptions()
    {
        MaxDegreeOfParallelism = 5
    };

    await Parallel.ForEachAsync(numbers, options, async (number, cancellationToken) => {
        await ExampleOfOperation();
        Console.WriteLine($"Processing the number: {number}");
    });
}

async Task ExampleOfOperation() =>
    await Task.Delay(1000);
