using System.Security.Cryptography;
using System.Text;

namespace Tracked.IO
{
    internal class Hashing
    {   
        // Thank you StackOverflow for the assist here. Hash the inputted string value to recieve
        // the SHA 256 hash value. This is so we can store our user/pass combo in hash format, not in
        // plain text or in an encryption method. It still isn't 100% secure, but, this is a personal
        // tool, not something I expect North Korean hackers to remote in and target. 
        public static string SHA512Hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA512 hash = SHA512.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
