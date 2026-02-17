using System;
using Cibar.Blowfish.Util;

namespace Hashing
{
    internal class BlConvertererFunctions
    {
        private const string MONKEY = "LetMEiNnoW";
        public string[] BlConverterUserPassword(string initialPassword)
        {
            string unSafePassword = "";
            string decryptedBlowfishPW = "";

            unSafePassword = CibBlowfishEncrypt(initialPassword);
            My.MyProject.Forms.Form1.BlowfishEncryptedTextBox.Text = unSafePassword;

            decryptedBlowfishPW = CibBlowfishDecrypt(unSafePassword);
            My.MyProject.Forms.Form1.BlowfishDecryptedTextBox.Text = decryptedBlowfishPW;
            string[] newPasswordSalt;

            newPasswordSalt = HashifyPassword(unSafePassword);
            return newPasswordSalt;
        }

        public string BlConverterUserPasswordWithSalt(string initialPassword, string initialSalt)
        {
            string unSafePassword = "";
            string decryptedBlowfishPW = "";

            unSafePassword = CibBlowfishEncrypt(initialPassword);
            My.MyProject.Forms.Form1.WithSaltBlowfishEncryptTextBox.Text = unSafePassword;

            decryptedBlowfishPW = CibBlowfishDecrypt(unSafePassword);
            My.MyProject.Forms.Form1.WithSaltBlowfishDecryptPWTextBox.Text = decryptedBlowfishPW;
            string newHash;
            newHash = HashifyPasswordWithSalt(decryptedBlowfishPW, initialSalt);
            return newHash;
        }

        public string CibBlowfishDecrypt(string password)
        {
            try
            {
                var CIBBlowfishUtil = new CCibEncryptionUtil();
                string decryptedPass = CIBBlowfishUtil.DecryptPass(password);
                return decryptedPass;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string CibBlowfishEncrypt(string password)
        {
            try
            {
                var CIBBlowfishUtil = new CCibEncryptionUtil();
                string encryptedPass = CIBBlowfishUtil.EncryptPass(password);
                return encryptedPass;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string CibarEvergreenEncryptDecrypt(string pkey, string type)
        {
            try
            {
                var securedString = string.Empty;
                var cbcipher = new CibCipher();
                if (type == "encrypt") {
                    securedString = CibCipher.Encode(pkey);
                }
                else
                {
                    securedString = CibCipher.Decode(pkey);
                }
                return securedString;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string[] HashifyPassword(string decryptedPass)
        {
            string[] newHashSalt;
            try
            {
                newHashSalt = CIBSaltHashWrapper.SaltyHasbrowns.CreateNewHashSalt(decryptedPass);
                return newHashSalt;
            }
            catch (Exception ex)
            {
                return new string[1];
            }
        }

        public string HashifyPasswordWithSalt(string decryptedPass, string givenSalt)
        {
            string newHash;
            try
            {
                newHash = CIBSaltHashWrapper.SaltyHasbrowns.CreateNewHashFromSalt(decryptedPass, givenSalt);
                return newHash;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}