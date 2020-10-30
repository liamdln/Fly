using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fly.Components
{
    class Cipher
    {

        private const string IV = "UQr~&3ZFuN2<Fz3x"; // 16 chars for 128bits
        private const string KEY = "!922~`y;jX8.nx@8yUM<UwT7HMv}p%eN"; // 32 chars = 256 bits
        private const int CRYPTO_INPUT_OFFSET = 0;

        public static string Encrypt(string messageToEncrypt)
        {

            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(messageToEncrypt);
            AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                Key = ASCIIEncoding.ASCII.GetBytes(KEY),
                IV = ASCIIEncoding.ASCII.GetBytes(IV),
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            ICryptoTransform encryptor = cryptoProvider.CreateEncryptor(cryptoProvider.Key, cryptoProvider.IV);

            byte[] encryptedText = encryptor.TransformFinalBlock(textBytes, CRYPTO_INPUT_OFFSET, textBytes.Length);
            encryptor.Dispose();

            return Convert.ToBase64String(encryptedText);

        }

        public static string Decrypt(string messageToDecrypt)
        {

            byte[] encryptedBytes = Convert.FromBase64String(messageToDecrypt);
            AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                Key = ASCIIEncoding.ASCII.GetBytes(KEY),
                IV = ASCIIEncoding.ASCII.GetBytes(IV),
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            ICryptoTransform decryptor = cryptoProvider.CreateDecryptor(cryptoProvider.Key, cryptoProvider.IV);

            byte[] decryptedText = decryptor.TransformFinalBlock(encryptedBytes, CRYPTO_INPUT_OFFSET, encryptedBytes.Length);
            decryptor.Dispose();

            return ASCIIEncoding.ASCII.GetString(decryptedText);

        }

    }
}
