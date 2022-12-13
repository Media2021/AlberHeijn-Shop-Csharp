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
    }
}
