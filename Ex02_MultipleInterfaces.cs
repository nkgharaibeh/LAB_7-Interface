using System;

namespace Ex02_MultipleInterfaces
{
    interface IRead
    {
        void Read();
    }

    interface IWrite
    {
        void Write();
    }

    // A class can implement MULTIPLE interfaces (unlike classes inheritance).
    class SecureAccount : IRead, IWrite
    {
        public void Read()
        {
            Console.WriteLine("Reading secure account balance...");
        }

        public void Write()
        {
            Console.WriteLine("Writing (updating) secure account balance...");
        }
    }

    class Program
    {
        static void Main()
        {
            SecureAccount acc = new SecureAccount();

            acc.Read();
            acc.Write();

            Console.ReadKey();
        }
    }
}

/*
KEY NOTES:

- From the slides: "Interfaces support multiple inheritance".
- In Lab 5, classes could inherit from only ONE base class.
- Here, SecureAccount implements IRead AND IWrite together.
*/
