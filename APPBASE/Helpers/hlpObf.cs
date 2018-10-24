using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace APPBASE.Helpers
{
    public class hlpObf
    {
        private static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");

        /// <summary>
        /// Function to create random key
        /// </summary>
        /// <returns></returns>
        public static string setRandomKey(int pnLen)
        {
            string vResult;
            Random voRandom = new Random();
            int vnRandomCombination;

            vResult = "";
            for (int i = 0; i < pnLen; i++)
            {
                vnRandomCombination = voRandom.Next(3);

                switch (vnRandomCombination)
                {
                    case 1:
                        vResult = vResult + char.ConvertFromUtf32(voRandom.Next(65, 90));
                        break;
                    case 2:
                        vResult = vResult + char.ConvertFromUtf32(voRandom.Next(97, 122));
                        break;
                    case 3:
                        vResult = vResult + char.ConvertFromUtf32(voRandom.Next(48, 57));
                        break;
                    default:
                        vResult = vResult + char.ConvertFromUtf32(voRandom.Next(97, 122));
                        break;
                }

            }

            return vResult;
        }
        /// <summary>
        /// Function to create fixed key
        /// </summary>
        /// <returns></returns>
        public static string setFixedKey()
        {
            string vResult;
            Random voRandom = new Random();

            vResult = "GCH";

            return vResult;
        }
        /// <summary>
        /// Function to get random key
        /// </summary>
        /// <returns></returns>
        public static string getRandomKey(string psEncryptedString, int pnLen)
        {
            string vResult;

            vResult = psEncryptedString.Substring(0, pnLen);

            return vResult;
        }
        /// <summary>
        /// Function to get fixed key
        /// </summary>
        /// <returns></returns>
        public static string getFixedKey()
        {
            string vResult;

            vResult = setFixedKey();

            return vResult;
        }
        /// <summary>
        /// Function random encrypt
        /// </summary>
        /// <param name="psValue">Text to encrypt</param>
        /// <returns>Encrypted value</returns>
        public static string randomEncrypt(string psValue)
        {
            string vResult;
            string vsKey;

            vsKey = setRandomKey(5);
            vResult = vsKey + EncryptStringAES(psValue, vsKey);

            return vResult;
        }
        /// <summary>
        /// Function random decrypt
        /// </summary>
        /// <param name="psValue">Text to decrypt</param>
        /// <returns>Decrypted value</returns>
        public static string randomDecrypt(string psValue)
        {
            string vResult="";
            string vsKey;
            string vstemp;

            try
            {
                vsKey = getRandomKey(psValue, 5);
                vstemp = psValue.Replace(vsKey, "");
                vResult = DecryptStringAES(psValue.Replace(vsKey, ""), vsKey);
            }
            catch (Exception e) { }


            return vResult;
        }
        /// <summary>
        /// Function fixed encrypted
        /// </summary>
        /// <param name="psValue">Text to encrypt</param>
        /// <returns>Encrypted value</returns>
        public static string fixedEncrypt(string psValue)
        {
            string vResult;
            string vsKey;

            vsKey = setFixedKey();
            vResult = EncryptStringAES(psValue, vsKey);

            return vResult;
        }
        public static string fixedDecrypt(string psValue)
        {
            string vResult;
            string vsKey;

            vResult = "";
            vsKey = getFixedKey();
            vResult = DecryptStringAES(psValue, vsKey);

            return vResult;
        }
        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                // with the specified key and IV.
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }
        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                // with the specified key and IV.
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }
    } //End public class hlpObf
} //End namespace APPBASE.Helper
