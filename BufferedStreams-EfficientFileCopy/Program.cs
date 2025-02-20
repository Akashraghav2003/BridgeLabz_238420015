using System;
using System.Diagnostics;
using System.IO;
class FileCopyPerformance
{
    static void Main()
    {
        string sourceFile = @"D:\akash gla university\capgemini problem\feature20-02-2025\NewReadWrite.txt";
        string destBuffered = @"D:\akash gla university\capgemini problem\feature20-02-2025\newBufferfile.txt";
        string destUnbuffered = @"D:\akash gla university\capgemini problem\feature20-02-2025\newFile.txt";
        // Ensure the source file exists for testing
        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file does not exist. Creating a test file...");
            CreateLargeFile(sourceFile, 100 * 1024 * 1024); // 100MB test file
        }

        // Measure time for unbuffered copy
        Stopwatch sw = Stopwatch.StartNew();
        CopyFileUnbuffered(sourceFile, destUnbuffered);
        sw.Stop();
        Console.WriteLine($"Unbuffered Copy Time: {sw.Elapsed} ms");

        // Measure time for buffered copy
        sw.Restart();
        CopyFileBuffered(sourceFile, destBuffered);
        sw.Stop();
        Console.WriteLine($"Buffered Copy Time: {sw.Elapsed} ms");
    }

    static void CopyFileUnbuffered(string source, string destination)
    {
        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096]; // 4KB
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destStream.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CopyFileBuffered(string source, string destination)
    {
        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedSource = new BufferedStream(sourceStream, 4096))
        using (BufferedStream bufferedDest = new BufferedStream(destStream, 4096))
        {
            byte[] buffer = new byte[4096]; // 4KB
            int bytesRead;
            while ((bytesRead = bufferedSource.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedDest.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CreateLargeFile(string filePath, int size)
    {
        byte[] data = new byte[1024]; // 1KB chunk
        Random rnd = new Random();
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            for (int i = 0; i < size / data.Length; i++)
            {
                rnd.NextBytes(data);
                fs.Write(data, 0, data.Length);
            }
        }
    }

}
