
class Program
{
    static void Main()
    {
        // Create a thread pool with 3 worker threads
        ThreadPool.SetMinThreads(3, 3);

        // Queue tasks to the thread pool
        ThreadPool.QueueUserWorkItem(DoTask, "Task 1");
        ThreadPool.QueueUserWorkItem(DoTask, "Task 2");
        ThreadPool.QueueUserWorkItem(DoTask, "Task 3");

        // Wait for all tasks to complete
        Thread.Sleep(1000); // Simulate main thread waiting

        Console.WriteLine("All tasks completed!");
    }

    static void DoTask(object state)
    {
        string taskName = (string)state;
        Console.WriteLine($"Executing {taskName} on thread {Thread.CurrentThread.ManagedThreadId}");
        // Simulate some work
        Thread.Sleep(500);
    }
}
