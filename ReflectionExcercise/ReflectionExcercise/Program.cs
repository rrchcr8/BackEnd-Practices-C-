using System;
using System.Linq;
using System.Reflection;

namespace ReflectionExcercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
                /*
                 * Reflection provides objects (of type Type) that describe assemblies, modules, and types. 
                */

                int i = 42;
                Type type = i.GetType();
                Console.WriteLine(type);
                TypeFeatures(type);


                // Using Reflection to get information of an Assembly:
                Assembly info = typeof(int).Assembly;
                Console.WriteLine(info);

            Assembly assem = typeof(Example).Assembly;

            Console.WriteLine("Assembly Full Name:");
            Console.WriteLine(assem.FullName);

            // The AssemblyName type can be used to parse the full name.
            AssemblyName assemName = assem.GetName();
            Console.WriteLine("\nName: {0}", assemName.Name);
            Console.WriteLine("Version: {0}.{1}",
                assemName.Version.Major, assemName.Version.Minor);

            Console.WriteLine("\nAssembly CodeBase:");
            Console.WriteLine(assem.CodeBase);

            // Create an object from the assembly, passing in the correct number
            // and type of arguments for the constructor.
            Object o = assem.CreateInstance("Example", false,
                BindingFlags.ExactBinding,
                null, new Object[] { 2 }, null, null);

            // Make a late-bound call to an instance method of the object.
            MethodInfo m = assem.GetType("Example").GetMethod("SampleMethod");
            Object ret = m.Invoke(o, new Object[] { 42 });
            Console.WriteLine("SampleMethod returned {0}.", ret);

            Console.WriteLine("\nAssembly entry point:");
            Console.WriteLine(assem.EntryPoint);

        }


        public static void TypeFeatures(Type t) {
            //Given a type, we will print some of their main features 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The main features are:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Base type: {0}", t.BaseType);
            Console.WriteLine("is class: {0}", t.IsClass);
            Console.WriteLine("is abstract: {0}", t.IsAbstract);
            Console.WriteLine("is sealed: {0}", t.IsSealed);
            Console.WriteLine("is generic: {0}", t.IsGenericTypeDefinition);

        }


        public class Example
        {
            private int factor;
            public Example(int f)
            {
                factor = f;
            }

            public int SampleMethod(int x)
            {
                Console.WriteLine("\nExample.SampleMethod({0}) executes.", x);
                return x * factor;
            }

            
        }
    }
}
