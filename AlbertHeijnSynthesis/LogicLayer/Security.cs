using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Security
    {
        public static string GenerateSalt()
        {
            byte[] saltByte = new byte[128 / 8];

            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetNonZeroBytes(saltByte);
            }

            return Convert.ToBase64String(saltByte);
        }

        public static string HashPassword(string password, string salt)
        {
            var saltByte = Convert.FromBase64String(salt);

            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltByte, 10000))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(64));
            }
        }

        //private static string HashPassword()
        //{

        //    using var sha = SHA256.Create();
        //    var asByte = Encoding.Default.GetBytes(password);
        //    var hashed = sha.ComputeHash(asByte);
        //    return Convert.ToBase64String(hashed);
        //}
        //private static int GenerateSalt(string password)
        //{

        //    Random random = new();
        //    int salt = random.Next(100000, 1000000);
        //    return salt;
        //}
    }
}
