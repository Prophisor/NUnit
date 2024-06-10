using NUnit.Framework;
using NUnit_App1;
using System;
using System.Security.Cryptography;
using System.Text;

namespace myTests
{
    [TestFixture]
    public class ScourseClassTest
    {
        private Form1 f1;

        [SetUp]
        public void Setup() // Diese Methode wird vor jedem Test ausgeführt
        {
            f1 = new Form1();
        }

        [Test]
        public void ProtectString_ShouldEncryptString_NotNull()
        {
            // Arrange
            string text = "TestString";

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(encryptedString, Is.Not.Null);
        }

        [Test]
        public void ProtectString_ShouldEncryptString_NotEmpty()
        {
            // Arrange
            string text = "TestString";

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(encryptedString, Is.Not.Empty);
        }

        [Test]
        public void ProtectString_ShouldEncryptString_NotEqualToOriginal()
        {
            // Arrange
            string text = "TestString";

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(text, Is.Not.EqualTo(encryptedString));
        }

        [Test]
        public void ProtectString_ShouldEncryptString_DecryptCorrectly()
        {
            // Arrange
            string text = "TestString";

            // Act
            string encryptedString = f1.ProtectString(text);
            byte[] protectedBytes = Convert.FromBase64String(encryptedString);
            byte[] unprotectedBytes = ProtectedData.Unprotect(protectedBytes, optionalEntropy: null, DataProtectionScope.LocalMachine);
            string decryptedString = Encoding.Unicode.GetString(unprotectedBytes);

            // Assert
            Assert.That(text, Is.EqualTo(decryptedString));
        }
        [Test]
        public void ProtectString_ShouldEncryptEmptyString()
        {
            // Arrange
            string text = "";

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(encryptedString, Is.Not.Null);
            Assert.That(encryptedString, Is.Not.Empty);

            // Decrypt
            byte[] protectedBytes = Convert.FromBase64String(encryptedString);
            byte[] unprotectedBytes = ProtectedData.Unprotect(protectedBytes, optionalEntropy: null, DataProtectionScope.LocalMachine);
            string decryptedString = Encoding.Unicode.GetString(unprotectedBytes);

            Assert.That(text, Is.EqualTo(decryptedString));
        }
        [Test]
        public void ProtectString_ShouldEncryptLongString()
        {
            // Arrange
            string text = new string('a', 1000); // 1000 characters long

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(encryptedString, Is.Not.Null);
            Assert.That(encryptedString, Is.Not.Empty);
            Assert.That(text, Is.Not.EqualTo(encryptedString));

            // Decrypt
            byte[] protectedBytes = Convert.FromBase64String(encryptedString);
            byte[] unprotectedBytes = ProtectedData.Unprotect(protectedBytes, optionalEntropy: null, DataProtectionScope.LocalMachine);
            string decryptedString = Encoding.Unicode.GetString(unprotectedBytes);

            Assert.That(text, Is.EqualTo(decryptedString));
        }
        [Test]
        public void ProtectString_ShouldEncryptStringWithSpecialCharacters()
        {
            // Arrange
            string text = "Special@#$%^&*()_+-=<>?/\\";

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(encryptedString, Is.Not.Null);
            Assert.That(encryptedString, Is.Not.Empty);
            Assert.That(text, Is.Not.EqualTo(encryptedString));

            // Decrypt
            byte[] protectedBytes = Convert.FromBase64String(encryptedString);
            byte[] unprotectedBytes = ProtectedData.Unprotect(protectedBytes, optionalEntropy: null, DataProtectionScope.LocalMachine);
            string decryptedString = Encoding.Unicode.GetString(unprotectedBytes);

            Assert.That(text, Is.EqualTo(decryptedString));
        }
        [Test]
        public void ProtectString_ShouldEncryptStringWithUnicodeCharacters()
        {
            // Arrange
            string text = "测试字符串"; // Chinese characters

            // Act
            string encryptedString = f1.ProtectString(text);

            // Assert
            Assert.That(encryptedString, Is.Not.Null);
            Assert.That(encryptedString, Is.Not.Empty);
            Assert.That(text, Is.Not.EqualTo(encryptedString));

            // Decrypt
            byte[] protectedBytes = Convert.FromBase64String(encryptedString);
            byte[] unprotectedBytes = ProtectedData.Unprotect(protectedBytes, optionalEntropy: null, DataProtectionScope.LocalMachine);
            string decryptedString = Encoding.Unicode.GetString(unprotectedBytes);

            Assert.That(text, Is.EqualTo(decryptedString));
        }

        


    }
}
