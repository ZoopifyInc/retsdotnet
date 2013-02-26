﻿#region LICENSE
//Copyright (c) 2013 LPS MLS Solutions

//Permission is hereby granted, free of charge, to any person obtaining a copy of
//this software and associated documentation files (the "Software"), to deal in
//the Software without restriction, including without limitation the rights to
//use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//of the Software, and to permit persons to whom the Software is furnished to do
//so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
#endregion

using System;

namespace PostObject
{
	public static class ConsoleHelper
	{
		public static void WriteFail(string message, params object[] args)
		{
			WriteLine(message, @"FAIL", ConsoleColor.Red, args);
		}

		public static void WriteWarn(string message, params object[] args)
		{
			WriteLine(message, @"WARN", ConsoleColor.Yellow, args);
		}

		public static void WriteOk(string message, params object[] args)
		{
			WriteLine(message, @" OK ", ConsoleColor.Green, args);
		}

		public static void WriteInfo(string message, params object[] args)
		{
			WriteLine(message, @"INFO", ConsoleColor.DarkCyan, args);
		}

		private static void WriteLine(string message, string status, ConsoleColor consoleColor, params object[] args)
		{
			Console.Write(@"[");
			Console.ForegroundColor = consoleColor;
			Console.Write(status);
			Console.ResetColor();
			Console.Write(@"] ");
			Console.WriteLine(message, args);
		}
	}
}
