using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace blog.managers
{
    //I believe this class shuld be limited in scope. It should take a password that is unhashed and create a hashed password
    public class PasswordManager
    {
        private readonly string unhashedPassword;
        public PasswordManager(string password)
        {
            unhashedPassword = password;
        }

        public int NumberOfIterations {get; set;}

        public string hashedPassword()
        {
            var salt = generateSalt();
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: this.unhashedPassword,
            salt: Convert.FromBase64String(salt),
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: this.NumberOfIterations,
            numBytesRequested: 256 / 8));
            return hashed;
        }
       
        private string generateSalt()
        {
            // Not sure if this api makes sense but I think it makes more sense to return base64 encoded string instead of bytes array
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = RandomNumberGenerator.Create())
            {
                rngCsp.GetNonZeroBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
    }
}