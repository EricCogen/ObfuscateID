using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCIH.Utilities.ObfuscateID;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Testing Lower Bounds
            for (int i = 1; i < 25; i++)
            {
                Debug.Assert(Obfuscate.Encode(i) != string.Empty, "Invalid Encoding");
                Debug.Assert((Obfuscate.Decode(Obfuscate.Encode(i)) == (long)i), "Invalid Decoding");
            }

            //Testing Middle Bounds
            for (int i = 10000; i < 10025; i++)
            {
                Debug.Assert(Obfuscate.Encode(i) != string.Empty, "Invalid Encoding");
                Debug.Assert(Obfuscate.Decode(Obfuscate.Encode(i)) == (long)i, "Invalid Decoding");
            }

            //Testing Upper Bounds
            for (long i = Int64.MaxValue - 25; i < Int64.MaxValue; i++)
            {
                Debug.Assert(Obfuscate.Encode(i) != string.Empty, "Invalid Encoding");
                Debug.Assert(Obfuscate.Decode(Obfuscate.Encode(i)) == i, "Invalid Decoding");
            }
        }
    }
}
