﻿using System;
using System.Windows;

namespace Lessons._05
{
    /// <summary>
    /// Print the ancestors of FooClass and FooStruct.
    /// Don't use "FooClass" and "FooStruct" as magic strings. 
    /// </summary>
    public class TaskA {
        public static void Run() {
			Console.WriteLine(typeof(FooClass).BaseType.ToString());
			Console.WriteLine(typeof(FooStruct).BaseType.ToString());
		}
	}

    class FooClass { }
    struct FooStruct { }
}
