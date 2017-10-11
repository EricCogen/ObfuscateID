using CCIH.Utilities.ObfuscateID;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedVal = string.Empty;
            long decodedVal = 0;

            //Testing Lower Bounds
            for (int i = 1; i < 25; i++)
            {
                encodedVal = Obfuscate.Encode(i);
                decodedVal = Obfuscate.Decode(Obfuscate.Encode(i));
                Console.WriteLine($"{i} == {encodedVal} == {decodedVal}: {(long)i == decodedVal}");
            }

            //Testing Middle Bounds
            for (int i = 999999; i <= 999999+50; i++)
            {
                encodedVal = Obfuscate.Encode(i);
                decodedVal = Obfuscate.Decode(Obfuscate.Encode(i));
                Console.WriteLine($"{i} == {encodedVal} == {decodedVal}: {(long)i == decodedVal}");
            }

            //Testing Upper Bounds
            for (long i = (Int64.MaxValue - 25); i < Int64.MaxValue; i++)
            {
                encodedVal = Obfuscate.Encode(i);
                decodedVal = Obfuscate.Decode(Obfuscate.Encode(i));
                Console.WriteLine($"{i} == {encodedVal} == {decodedVal}: {i == decodedVal}");
            }
        }
    }
}
