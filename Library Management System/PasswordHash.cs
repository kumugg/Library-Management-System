using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(64);

            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public bool VerifyPassword(string password, string storedHash)
        {
            var parts = storedHash.Split(':');
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] hash = Convert.FromBase64String(parts[1]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hashtocheck = pbkdf2.GetBytes(64);

            return CryptographicOperations.FixedTimeEquals(hash, hashtocheck);
        }
    }
}   