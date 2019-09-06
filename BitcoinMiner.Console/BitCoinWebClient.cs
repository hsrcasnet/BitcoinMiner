using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinMiner.Console
{
    class BitCoinWebClient
    {
        private static Random random = new Random();

        /// <summary>
        /// Simulates a Peer-to-Peer Bitcoin Pool.
        /// </summary>
        internal string Request(string method, string paramString)
        {
            var generatedData = GenerateRandomHex(200);
            return $"{{\"id\":3,\"result\":true,\"error\":null, \"data\": \"{generatedData}\"}}";
        }

        public static string GenerateRandomHex(int length)
        {
            const string chars = "ABCDEF0123456789"; // Hexadecimal characters
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
