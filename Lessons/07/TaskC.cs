﻿using System;
using System.IO;

namespace Lessons._07
{
    /// <summary>
    /// Improve implementation of TaskC and FileWriter 
    /// to release resources properly.
    /// </summary>
    public class TaskC
    {
        public static void Run()
        {
            const string FileName = "tmp.txt";

            var file = new FileWriter(FileName);
            file.Write("I love C# certification trainings.");

            File.Delete(FileName);
        }

        class FileWriter
        {
            private StreamWriter _fileStream;

            public FileWriter(string fileName)
            {
                _fileStream = File.CreateText(fileName);
                Console.WriteLine($"File {fileName} has been created.");
            }

            public void Write(string text)
            {
                _fileStream.Write(text);
            }
        }
    }
}