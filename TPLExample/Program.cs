

//Parallel.For(1, 101, i =>
//{
//    int square = i * i;
//    Console.WriteLine($"Square of {i} is {square}");
//});




//List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//Parallel.ForEach(names, name =>
//{
//    Console.WriteLine($"Hello, {name}!");
//});


//async Task DownloadImagesAsync()
//{
//    await Task.WhenAll(
//        Task.Run(() => Console.WriteLine("url1")),
//        Task.Run(() => Console.WriteLine("url2")),
//        Task.Run(() => Console.WriteLine("url3"))
//    );
//}


Task processDataTask = Task.Run(() => Console.WriteLine("1"));
Task saveDataTask = processDataTask.ContinueWith(prevTask => Console.WriteLine("2"));
await saveDataTask;



