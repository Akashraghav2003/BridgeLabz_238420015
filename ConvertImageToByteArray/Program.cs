using System;
using System.IO;
class Program
{
    static void Main()
    {
        string inputImagePath = @"C:\Users\dell\OneDrive\Pictures\Camera Roll 1\WIN_20241012_11_57_50_Pro.jpg";
        string outputImagePath = @"C:\Users\dell\OneDrive\Pictures\Camera Roll 1\WIN_20241012_11_57_50_Pro.jpg";
        try
        {
            // Convert image to byte array
            byte[] imageBytes = FileToByteArray(inputImagePath);

            // Write byte array back to image file
            ByteArrayToFile(outputImagePath, imageBytes);

            Console.WriteLine("Image conversion successful.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static byte[] FileToByteArray(string filePath)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                fs.CopyTo(ms);
            }
            return ms.ToArray();
        }
    }

    static void ByteArrayToFile(string filePath, byte[] byteArray)
    {
        using (MemoryStream ms = new MemoryStream(byteArray))
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                ms.CopyTo(fs);
            }
        }
    }

}
