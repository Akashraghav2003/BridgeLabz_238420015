using System;
using System.IO;
using NUnit.Framework;
using FileHandling;

namespace FileHandlingTest
{
    [TestFixture]
    public class FileProcessorTest
    {
        private FileProcessor fileProcessor;
        private string testFilePath;

        [SetUp]
        public void SetUp()
        {
            fileProcessor = new FileProcessor();
            testFilePath = "testfile.txt";

            // Clean up any existing test file before each test
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [TearDown]
        public void TearDown()
        {
            // Delete the test file after each test to avoid conflicts
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [Test]
        public void WriteToFile_ShouldCreateFileAndWriteContent()
        {
            string content = "Hello, this is a test.";

            fileProcessor.WriteToFile(testFilePath, content);

            Assert.IsTrue(File.Exists(testFilePath), "File should exist after writing.");
            string result = File.ReadAllText(testFilePath);
            Assert.AreEqual(content, result, "File content should match the written content.");
        }

        [Test]
        public void ReadFromFile_ShouldReturnCorrectContent()
        {
            string expectedContent = "File reading test";
            File.WriteAllText(testFilePath, expectedContent);

            string actualContent = fileProcessor.ReadFromFile(testFilePath);

            Assert.AreEqual(expectedContent, actualContent, "Read content should match the file content.");
        }

        [Test]
        public void ReadFromFile_NonExistentFile_ShouldThrowFileNotFoundException()
        {
            Assert.Throws<FileNotFoundException>(() =>
                fileProcessor.ReadFromFile("nonexistent.txt"),
                "Reading a non-existent file should throw FileNotFoundException.");
        }

        [Test]
        public void WriteToFile_EmptyFileName_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                fileProcessor.WriteToFile("", "Some content"),
                "Empty filename should throw ArgumentException.");
        }
    }
}
