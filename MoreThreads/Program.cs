using System;
using System.Threading;

class Program
{
    // Shared resource (a lock)
    static readonly object sharedLock = new object();

    // Function to be executed by each thread
    static void WorkerThread(object threadId)
    {
        int id = (int)threadId;

        lock (sharedLock)
        {
            Console.WriteLine($"Thread {id} Started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread {id} is working");
                Task.Delay(100);
            }
            Console.WriteLine($"Thread {id} Done");
        }
    }

    static void Main()
    {
        int numThreads = 24;
        Thread[] threads = new Thread[numThreads];

        // Create and start worker threads
        for (int i = 0; i < numThreads; i++)
        {
            threads[i] = new Thread(WorkerThread);
            threads[i].Start(i);
        }

        // Wait for all threads to finish
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("All threads completed");
    }
}
