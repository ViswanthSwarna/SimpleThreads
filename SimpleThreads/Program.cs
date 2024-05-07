using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create two threads
        Thread thread1 = new Thread(DoTask1);
        Thread thread2 = new Thread(DoTask2);

        // Start the threads
        thread1.Start();
        thread2.Start();

        // Wait for both threads to finish
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both tasks completed!");
    }

    static void DoTask1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Task 1: Number {i}");
            Thread.Sleep(100); // Simulate some work
        }
    }

    static void DoTask2()
    {
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine($"Task 2: Letter {c}");
            Thread.Sleep(100); // Simulate some work
        }
    }
}
