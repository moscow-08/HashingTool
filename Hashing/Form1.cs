using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using Cibar.Blowfish.Util;
namespace Hashing
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HashBttn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBx.Text != "")
            {
                string[] returnedHashSalt;
                returnedHashSalt = CIBSaltHashWrapper.SaltyHasbrowns.CreateNewHashSalt(PasswordTxtBx.Text);
                HashedPasswordTxtBx.Text = returnedHashSalt[0];
                SaltTxtBx.Text = returnedHashSalt[1];
            }
            else
            {
                MessageBox.Show("Enter a password!");
            }
        }

        private void VerifyHashBttn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBx.Text != "" && HashedPasswordTxtBx.Text != "" && SaltTxtBx.Text != "")
            {
                if (!CIBSaltHashWrapper.SaltyHasbrowns.VerifyHash(PasswordTxtBx.Text, HashedPasswordTxtBx.Text, SaltTxtBx.Text))
                {
                    Interaction.MsgBox("You have entered an invalid Username or Password", MsgBoxStyle.Critical, "Login Alert");
                }
                else
                {
                    Interaction.MsgBox("Login Success!", MsgBoxStyle.Information, "Login Alert");
                }
            }
            else
            {
                MessageBox.Show("Enter a password!");
            }
        }

        private void TestsaltBttn_Click(object sender, EventArgs e)
        {
            if (SaltTesterPWtxtbx.Text != "" && SaltTesterSalttxtbx.Text != "")
            {
                string returnedHashSalt;
                returnedHashSalt = CIBSaltHashWrapper.SaltyHasbrowns.CreateNewHashFromSalt(SaltTesterPWtxtbx.Text, SaltTesterSalttxtbx.Text);
                SaltTesterHPWtxtbx.Text = returnedHashSalt;
            }
            else
            {
                MessageBox.Show("Enter a password!");
            }
        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {
            if (InitialPasswordTextBox.Text != "")
            {
                var BlConverterFunctions = new BlConvertererFunctions();
                string[] decryptHashSalt;
                decryptHashSalt = BlConverterFunctions.BlConverterUserPassword(InitialPasswordTextBox.Text);
                DecryptedHashedPWTextBox.Text = decryptHashSalt[0];
                DecryptedSaltTextBox.Text = decryptHashSalt[1];
            }
            else
            {
                MessageBox.Show("Enter a password to BlConverter!");
            }
        }

        private void WithSaltBlConvertererButton_Click(object sender, EventArgs e)
        {
            if (InitialPasswordTextBox.Text != "")
            {
                var BlConverterFunctions = new BlConvertererFunctions();
                string decryptHash;
                decryptHash = BlConverterFunctions.BlConverterUserPasswordWithSalt(WithSaltPWTextBox.Text, WithSaltTextBox.Text);
                WithSaltBlowfishHashedPWTextBox.Text = decryptHash;
            }
            else
            {
                MessageBox.Show("Enter a password to BlConverter!");
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (encypted_pkey_txtbx.Text != string.Empty){
                var BlConverterFunctions = new BlConvertererFunctions();
                string encryptedString = BlConverterFunctions.CibarEvergreenEncryptDecrypt(encypted_pkey_txtbx.Text,"decrypt");
                unencypted_pkey_txtbx.Text = encryptedString;
            }
        }
        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (unencypted_pkey_txtbx.Text != string.Empty)
            {
                var BlConverterFunctions = new BlConvertererFunctions();
                string encryptedString = BlConverterFunctions.CibarEvergreenEncryptDecrypt(unencypted_pkey_txtbx.Text, "encrypt");
                encypted_pkey_txtbx.Text = encryptedString;
            }
        }
    }
}