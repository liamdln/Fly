using Fly.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly.Tests
{
    [TestClass]
    public class CipherTests
    {

        [TestMethod]
        public void CipherEncrypt()
        {
            // Arrange
            string originalValue = "1234567891234567";
            string expectedEncryptedValue = "8BdrRI8/NoF+0v4TK/ya9eu8YW7wWIDvHj64zyzTMEw="; // https://www.devglan.com/online-tools/aes-encryption-decryption

            // Act
            string encryptedValue = Cipher.Encrypt(originalValue);

            // Assert
            Assert.AreEqual(expectedEncryptedValue, encryptedValue);
        }

        [TestMethod]
        public void CipherDecrypt()
        {
            // Arrange
            string originalValue = "rUCKFPRIWqSAgJAG4IlXBHqVGWFzERxQ59GkIZUzRZs=";
            string expectedEncryptedValue = "9876987612341234";

            // Act
            string encryptedValue = Cipher.Decrypt(originalValue);

            // Assert
            Assert.AreEqual(expectedEncryptedValue, encryptedValue);
        }

    }
}
