using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;
class Program
{
    static void Main()
    {
        var pipe = new AnonymousPipeServerStream(PipeDirection.Out);
        var readPipeHandle = pipe.GetClientHandleAsString();
        // Create writer and reader threads
        Thread writerThread = new Thread(() => Writer(pipe));
        Thread readerThread = new Thread(() => Reader(readPipeHandle));

        writerThread.Start();
        readerThread.Start();

        writerThread.Join();
        readerThread.Join();
    }

    static void Writer(AnonymousPipeServerStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8, leaveOpen: false))
            {
                writer.AutoFlush = true;
                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine($"Message {i}"); // Write message to pipe
                    Thread.Sleep(500); // Simulate delay
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Writer Exception: " + e.Message);
        }
    }

    static void Reader(string pipeHandle)
    {
        try
        {
            using (var pipe = new AnonymousPipeClientStream(PipeDirection.In, pipeHandle))
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + message); // Read message from pipe
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Reader Exception: " + e.Message);
        }
    }

}
