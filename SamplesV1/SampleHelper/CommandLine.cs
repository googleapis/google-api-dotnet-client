/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Reflection;

namespace Google.Apis.Samples.Helper
{
    /// <summary>
    /// Contains helper methods for command line operation
    /// </summary>
    public class CommandLine
    {
        /// <summary>
        /// Creates a new instance of T and fills all public fields by requesting input from the user
        /// </summary>
        /// <typeparam name="T">Class with a default constructor</typeparam>
        /// <returns>Instance of T with filled in public fields</returns>
        public static T CreateClassFromUserinput<T>()
        {
            var type = typeof (T);

            // Create an instance of T
            T settings = Activator.CreateInstance<T>();

            WriteLine("^1 Please enter values for the {0}:", Reflection.GetDescriptiveName(type));

            // Fill in parameters
            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                do
                {
                    Write("   ^1{0} [^2{1}^1]: ^9",
                          Reflection.GetDescriptiveName(field),
                          field.GetValue(settings));

                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                        break; // Stick with the default value

                    try
                    {
                        object convertedInput = Convert.ChangeType(input, field.FieldType);
                        field.SetValue(settings, convertedInput);
                        break;
                    }
                    catch (InvalidCastException)
                    {
                        WriteLine("^6Please enter a valid value!");
                    }
                } while (true); // Re-run the action until the user enters a valid input
            }

            WriteLine();
            return settings;
        }
    
        /// <summary>
        /// Displays the Google Sample Header
        /// </summary>
        public static void DisplayGoogleSampleHeader(string applicationName)
        {
            WriteLine(@"^3  ___  ^6     ^8     ^3      ^4 _  ^6    ");
            WriteLine(@"^3 / __| ^6 ___ ^8 ___ ^3 __ _ ^4| | ^6 __  ");
            WriteLine(@"^3| (_ \ ^6/ _ \^8/ _ \^3/ _` |^4| | ^6/-_) ");
            WriteLine(@"^3 \___| ^6\___/^8\___/^3\__, |^4|_| ^6\___| ");
            WriteLine(@"^3       ^6     ^8     ^3|___/ ^4    ^6    ");
            WriteLine("^4 API Samples -- {0}", applicationName);
            WriteLine("^4 Copyright Google Inc 2011");
            WriteLine();
        }

        /// <summary>
        /// Displays the default "Press any key to exit" message, and waits for an user key input
        /// </summary>
        public static void PressAnyKeyToExit()
        {
            WriteLine();
            WriteLine("^8 Press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Writes the specified text to the console
        /// Applies special color filters (^0, ^1, ...)
        /// </summary>
        public static void Write(string format, params object[] values)
        {
            string text = String.Format(format, values);
            Console.ForegroundColor = ConsoleColor.Gray;

            while (text.Contains("^"))
            {
                int index = text.IndexOf("^");

                // Check if a number follows the index
                if (index+1 < text.Length && Char.IsDigit(text[index+1]))
                {
                    // Yes - it is a color notation
                    Console.Write(text.Substring(0, index)); // Pre-Colornotation text
                    Console.ForegroundColor = (ConsoleColor) (text[index + 1] - '0' + 6);
                    text = text.Substring(index + 2); // Skip the two-char notation
                }
                else
                {
                    // Skip ahead
                    Console.Write(text.Substring(0, index));
                    text = text.Substring(index + 1);
                }
            }

            // Write the remaining text
            Console.Write(text);
        }

        /// <summary>
        /// Writes the specified text to the console
        /// Applies special color filters (^0, ^1, ...)
        /// </summary>
        public static void WriteLine(string format, params object[] values)
        {
            Write(format+Environment.NewLine, values);
        }

        /// <summary>
        /// Writes an empty line into the console stream
        /// </summary>
        public static void WriteLine()
        {
            WriteLine("");
        }
    }
}
