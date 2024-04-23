using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyBanHang.Application.Helper
{
    public class HashPassword
    {
        public static string KeyString { get; set; } = string.Empty;

        /*public static string GetHash(string password)
        {
            *//*byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();*//*
            if (password != null)
            {
                var saltBytes = Encoding.ASCII.GetBytes(KeyString);
                var passwordBytes = Encoding.ASCII.GetBytes(password);
                var hmac = new HMACSHA256(saltBytes);
                var hash = hmac.ComputeHash(passwordBytes);
                var hexHash = BitConverter.ToString(hash).Replace("-", "");
                return hexHash;
            }
            return "";
        }


        public static bool VerifyHash(string password, string hashedPassword)
        {
            *//*var hashOfInput = GetHash(hashAlgorithm, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;*//*

            if (password != null)
            {
                string passwordInput = GetHash(password);
                if (passwordInput == hashedPassword)
                    return true;
                else
                    return false;
            }
            return false;
        }*/

        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


        public static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            var hashOfInput = GetHash(hashAlgorithm, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

    }
}
