using System;

namespace DotNetConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates.Play();
        }
    }

    public static class Delegates
    {
        public delegate string Handler(string eventName);

        public static void Play()
        {
            Handler handler = (string eventName) =>
            {
                Console.WriteLine("Sample 1");
                return "adsa";
            };
            //handler += Sample2;

            var a = handler.Invoke("eventName");
            Console.WriteLine(a);
        }

        public static string Sample2(string eventName1)
        {
            Console.WriteLine("Sample 2");
            return "dasda";
        }


    }
}
