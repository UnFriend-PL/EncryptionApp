using System.Security.Cryptography;
using System.Text;

namespace HashApp
{
    public class Encryption
    {
        public static string initialDirectory = "c:\\";
        public static string encryptedFileName = "encryptedFile.txt";

        public static string EncryptAESFile(string data, string key)
        {
            byte[] initializationVector = Encoding.ASCII.GetBytes("abcede0123456789");
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = initializationVector;
                var symmetricEncryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream as Stream, symmetricEncryptor, CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter(cryptoStream as Stream))
                        {
                            streamWriter.Write(data);
                        }
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
        }

        public static string DecryptAESFile(string cipherText, string key)
        {
            byte[] initializationVector = Encoding.ASCII.GetBytes("abcede0123456789");
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = initializationVector;
                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (var memoryStream = new MemoryStream(buffer))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream as Stream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var streamReader = new StreamReader(cryptoStream as Stream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static string EncryptRSAFile(string data, RSAParameters rsaParameters)
        {
            using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rsaCryptoServiceProvider.ImportParameters(rsaParameters);
                var byteData = Encoding.UTF8.GetBytes(data);
                var encryptedData = rsaCryptoServiceProvider.Encrypt(byteData, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string GenerateRSAPrivateKey()
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                string privateKeyXml = rsa.ToXmlString(true);
                return privateKeyXml;
            }
        }
        public static RSA ReadPrivateKeyFromFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string privateKeyXml = reader.ReadToEnd();
                    RSA rsa = RSA.Create();
                    rsa.FromXmlString(privateKeyXml);
                    return rsa;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading private key from file: {ex.Message}");
                return null;
            }
        }
        public static string DecryptRSAFile(string encryptedText, RSAParameters privateKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);

                byte[] encryptedData = Convert.FromBase64String(encryptedText);
                byte[] decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);

                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }

}
