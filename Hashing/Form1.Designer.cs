using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Hashing
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.HashBttn = new System.Windows.Forms.Button();
            this.VerifyHashBttn = new System.Windows.Forms.Button();
            this.SaltTxtBx = new System.Windows.Forms.TextBox();
            this.HashedPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.SaltTesterHPWtxtbx = new System.Windows.Forms.TextBox();
            this.SaltTesterSalttxtbx = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.SaltTesterPWtxtbx = new System.Windows.Forms.TextBox();
            this.TestsaltBttn = new System.Windows.Forms.Button();
            this.ConversionButton = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.DecryptedHashedPWTextBox = new System.Windows.Forms.TextBox();
            this.DecryptedSaltTextBox = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.InitialPasswordTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.BlowfishDecryptedTextBox = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.BlowfishEncryptedTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.WithSaltBlowfishDecryptPWTextBox = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.WithSaltBlowfishEncryptTextBox = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.WithSaltBlConvertererButton = new System.Windows.Forms.Button();
            this.WithSaltPWTextBox = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.WithSaltTextBox = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.WithSaltBlowfishHashedPWTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.encypted_pkey_txtbx = new System.Windows.Forms.TextBox();
            this.unencypted_pkey_txtbx = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Location = new System.Drawing.Point(25, 32);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.Size = new System.Drawing.Size(359, 20);
            this.PasswordTxtBx.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Password";
            // 
            // HashBttn
            // 
            this.HashBttn.Location = new System.Drawing.Point(24, 156);
            this.HashBttn.Name = "HashBttn";
            this.HashBttn.Size = new System.Drawing.Size(75, 23);
            this.HashBttn.TabIndex = 4;
            this.HashBttn.Text = "Hash";
            this.HashBttn.UseVisualStyleBackColor = true;
            this.HashBttn.Click += new System.EventHandler(this.HashBttn_Click);
            // 
            // VerifyHashBttn
            // 
            this.VerifyHashBttn.Location = new System.Drawing.Point(308, 156);
            this.VerifyHashBttn.Name = "VerifyHashBttn";
            this.VerifyHashBttn.Size = new System.Drawing.Size(75, 23);
            this.VerifyHashBttn.TabIndex = 6;
            this.VerifyHashBttn.Text = "Verify Hash";
            this.VerifyHashBttn.UseVisualStyleBackColor = true;
            this.VerifyHashBttn.Click += new System.EventHandler(this.VerifyHashBttn_Click);
            // 
            // SaltTxtBx
            // 
            this.SaltTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.SaltTxtBx.Location = new System.Drawing.Point(25, 74);
            this.SaltTxtBx.Name = "SaltTxtBx";
            this.SaltTxtBx.ReadOnly = true;
            this.SaltTxtBx.Size = new System.Drawing.Size(359, 20);
            this.SaltTxtBx.TabIndex = 7;
            // 
            // HashedPasswordTxtBx
            // 
            this.HashedPasswordTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.HashedPasswordTxtBx.Location = new System.Drawing.Point(24, 121);
            this.HashedPasswordTxtBx.Name = "HashedPasswordTxtBx";
            this.HashedPasswordTxtBx.ReadOnly = true;
            this.HashedPasswordTxtBx.Size = new System.Drawing.Size(359, 20);
            this.HashedPasswordTxtBx.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(25, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(25, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Salt";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(93, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Hashed Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(495, 105);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(93, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Hashed Password";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(495, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(25, 13);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Salt";
            // 
            // SaltTesterHPWtxtbx
            // 
            this.SaltTesterHPWtxtbx.Location = new System.Drawing.Point(495, 121);
            this.SaltTesterHPWtxtbx.Name = "SaltTesterHPWtxtbx";
            this.SaltTesterHPWtxtbx.Size = new System.Drawing.Size(359, 20);
            this.SaltTesterHPWtxtbx.TabIndex = 14;
            // 
            // SaltTesterSalttxtbx
            // 
            this.SaltTesterSalttxtbx.Location = new System.Drawing.Point(495, 74);
            this.SaltTesterSalttxtbx.Name = "SaltTesterSalttxtbx";
            this.SaltTesterSalttxtbx.Size = new System.Drawing.Size(359, 20);
            this.SaltTesterSalttxtbx.TabIndex = 13;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(495, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 13);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Password";
            // 
            // SaltTesterPWtxtbx
            // 
            this.SaltTesterPWtxtbx.Location = new System.Drawing.Point(495, 32);
            this.SaltTesterPWtxtbx.Name = "SaltTesterPWtxtbx";
            this.SaltTesterPWtxtbx.Size = new System.Drawing.Size(359, 20);
            this.SaltTesterPWtxtbx.TabIndex = 11;
            // 
            // TestsaltBttn
            // 
            this.TestsaltBttn.Location = new System.Drawing.Point(637, 156);
            this.TestsaltBttn.Name = "TestsaltBttn";
            this.TestsaltBttn.Size = new System.Drawing.Size(75, 23);
            this.TestsaltBttn.TabIndex = 17;
            this.TestsaltBttn.Text = "Test Salt";
            this.TestsaltBttn.UseVisualStyleBackColor = true;
            this.TestsaltBttn.Click += new System.EventHandler(this.TestsaltBttn_Click);
            // 
            // ConversionButton
            // 
            this.ConversionButton.Location = new System.Drawing.Point(628, 131);
            this.ConversionButton.Name = "ConversionButton";
            this.ConversionButton.Size = new System.Drawing.Size(93, 23);
            this.ConversionButton.TabIndex = 24;
            this.ConversionButton.Text = "Test Conversion";
            this.ConversionButton.UseVisualStyleBackColor = true;
            this.ConversionButton.Click += new System.EventHandler(this.ConversionButton_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(24, 118);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(93, 13);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "Hashed Password";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(24, 69);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(25, 13);
            this.Label8.TabIndex = 22;
            this.Label8.Text = "Salt";
            // 
            // DecryptedHashedPWTextBox
            // 
            this.DecryptedHashedPWTextBox.Location = new System.Drawing.Point(24, 134);
            this.DecryptedHashedPWTextBox.Name = "DecryptedHashedPWTextBox";
            this.DecryptedHashedPWTextBox.Size = new System.Drawing.Size(359, 20);
            this.DecryptedHashedPWTextBox.TabIndex = 21;
            // 
            // DecryptedSaltTextBox
            // 
            this.DecryptedSaltTextBox.Location = new System.Drawing.Point(24, 85);
            this.DecryptedSaltTextBox.Name = "DecryptedSaltTextBox";
            this.DecryptedSaltTextBox.Size = new System.Drawing.Size(359, 20);
            this.DecryptedSaltTextBox.TabIndex = 20;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(24, 16);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(53, 13);
            this.Label9.TabIndex = 19;
            this.Label9.Text = "Password";
            // 
            // InitialPasswordTextBox
            // 
            this.InitialPasswordTextBox.Location = new System.Drawing.Point(24, 32);
            this.InitialPasswordTextBox.Name = "InitialPasswordTextBox";
            this.InitialPasswordTextBox.Size = new System.Drawing.Size(359, 20);
            this.InitialPasswordTextBox.TabIndex = 18;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.PasswordTxtBx);
            this.GroupBox1.Controls.Add(this.HashBttn);
            this.GroupBox1.Controls.Add(this.VerifyHashBttn);
            this.GroupBox1.Controls.Add(this.SaltTxtBx);
            this.GroupBox1.Controls.Add(this.HashedPasswordTxtBx);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TestsaltBttn);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.SaltTesterPWtxtbx);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.SaltTesterSalttxtbx);
            this.GroupBox1.Controls.Add(this.SaltTesterHPWtxtbx);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(907, 194);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Hashing Tools";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.BlowfishDecryptedTextBox);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.BlowfishEncryptedTextBox);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.ConversionButton);
            this.GroupBox2.Controls.Add(this.InitialPasswordTextBox);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.DecryptedSaltTextBox);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.DecryptedHashedPWTextBox);
            this.GroupBox2.Location = new System.Drawing.Point(12, 212);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(907, 170);
            this.GroupBox2.TabIndex = 26;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Basic BlConverterer Function";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(495, 69);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(147, 13);
            this.Label11.TabIndex = 28;
            this.Label11.Text = "Blowfish Decrypted Password";
            // 
            // BlowfishDecryptedTextBox
            // 
            this.BlowfishDecryptedTextBox.Location = new System.Drawing.Point(495, 85);
            this.BlowfishDecryptedTextBox.Name = "BlowfishDecryptedTextBox";
            this.BlowfishDecryptedTextBox.Size = new System.Drawing.Size(359, 20);
            this.BlowfishDecryptedTextBox.TabIndex = 27;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(495, 16);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(146, 13);
            this.Label10.TabIndex = 26;
            this.Label10.Text = "Blowfish Encrypted Password";
            // 
            // BlowfishEncryptedTextBox
            // 
            this.BlowfishEncryptedTextBox.Location = new System.Drawing.Point(495, 32);
            this.BlowfishEncryptedTextBox.Name = "BlowfishEncryptedTextBox";
            this.BlowfishEncryptedTextBox.Size = new System.Drawing.Size(359, 20);
            this.BlowfishEncryptedTextBox.TabIndex = 25;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.WithSaltBlowfishDecryptPWTextBox);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.WithSaltBlowfishEncryptTextBox);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.WithSaltBlConvertererButton);
            this.GroupBox3.Controls.Add(this.WithSaltPWTextBox);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.WithSaltTextBox);
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Controls.Add(this.WithSaltBlowfishHashedPWTextBox);
            this.GroupBox3.Location = new System.Drawing.Point(12, 388);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(907, 179);
            this.GroupBox3.TabIndex = 29;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "BlConverterer with Salt";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(492, 65);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(147, 13);
            this.Label12.TabIndex = 28;
            this.Label12.Text = "Blowfish Decrypted Password";
            // 
            // WithSaltBlowfishDecryptPWTextBox
            // 
            this.WithSaltBlowfishDecryptPWTextBox.Location = new System.Drawing.Point(492, 81);
            this.WithSaltBlowfishDecryptPWTextBox.Name = "WithSaltBlowfishDecryptPWTextBox";
            this.WithSaltBlowfishDecryptPWTextBox.Size = new System.Drawing.Size(359, 20);
            this.WithSaltBlowfishDecryptPWTextBox.TabIndex = 27;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(489, 16);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(146, 13);
            this.Label13.TabIndex = 26;
            this.Label13.Text = "Blowfish Encrypted Password";
            // 
            // WithSaltBlowfishEncryptTextBox
            // 
            this.WithSaltBlowfishEncryptTextBox.Location = new System.Drawing.Point(492, 32);
            this.WithSaltBlowfishEncryptTextBox.Name = "WithSaltBlowfishEncryptTextBox";
            this.WithSaltBlowfishEncryptTextBox.Size = new System.Drawing.Size(359, 20);
            this.WithSaltBlowfishEncryptTextBox.TabIndex = 25;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(24, 16);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(53, 13);
            this.Label14.TabIndex = 19;
            this.Label14.Text = "Password";
            // 
            // WithSaltBlConvertererButton
            // 
            this.WithSaltBlConvertererButton.Location = new System.Drawing.Point(628, 132);
            this.WithSaltBlConvertererButton.Name = "WithSaltBlConvertererButton";
            this.WithSaltBlConvertererButton.Size = new System.Drawing.Size(93, 23);
            this.WithSaltBlConvertererButton.TabIndex = 24;
            this.WithSaltBlConvertererButton.Text = "Test Conversion";
            this.WithSaltBlConvertererButton.UseVisualStyleBackColor = true;
            this.WithSaltBlConvertererButton.Click += new System.EventHandler(this.WithSaltBlConvertererButton_Click);
            // 
            // WithSaltPWTextBox
            // 
            this.WithSaltPWTextBox.Location = new System.Drawing.Point(24, 32);
            this.WithSaltPWTextBox.Name = "WithSaltPWTextBox";
            this.WithSaltPWTextBox.Size = new System.Drawing.Size(359, 20);
            this.WithSaltPWTextBox.TabIndex = 18;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(25, 116);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(93, 13);
            this.Label15.TabIndex = 23;
            this.Label15.Text = "Hashed Password";
            // 
            // WithSaltTextBox
            // 
            this.WithSaltTextBox.Location = new System.Drawing.Point(24, 81);
            this.WithSaltTextBox.Name = "WithSaltTextBox";
            this.WithSaltTextBox.Size = new System.Drawing.Size(359, 20);
            this.WithSaltTextBox.TabIndex = 20;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(25, 65);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(25, 13);
            this.Label16.TabIndex = 22;
            this.Label16.Text = "Salt";
            // 
            // WithSaltBlowfishHashedPWTextBox
            // 
            this.WithSaltBlowfishHashedPWTextBox.Location = new System.Drawing.Point(24, 132);
            this.WithSaltBlowfishHashedPWTextBox.Name = "WithSaltBlowfishHashedPWTextBox";
            this.WithSaltBlowfishHashedPWTextBox.Size = new System.Drawing.Size(359, 20);
            this.WithSaltBlowfishHashedPWTextBox.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Encrypt);
            this.groupBox4.Controls.Add(this.Decrypt);
            this.groupBox4.Controls.Add(this.unencypted_pkey_txtbx);
            this.groupBox4.Controls.Add(this.encypted_pkey_txtbx);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(928, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 192);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EVG Pkey Encryption";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Unencrypted Pkey";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Encrypted Pkey";
            // 
            // encypted_pkey_txtbx
            // 
            this.encypted_pkey_txtbx.Location = new System.Drawing.Point(144, 96);
            this.encypted_pkey_txtbx.Name = "encypted_pkey_txtbx";
            this.encypted_pkey_txtbx.Size = new System.Drawing.Size(208, 20);
            this.encypted_pkey_txtbx.TabIndex = 2;
            // 
            // unencypted_pkey_txtbx
            // 
            this.unencypted_pkey_txtbx.Location = new System.Drawing.Point(144, 32);
            this.unencypted_pkey_txtbx.Name = "unencypted_pkey_txtbx";
            this.unencypted_pkey_txtbx.Size = new System.Drawing.Size(208, 20);
            this.unencypted_pkey_txtbx.TabIndex = 3;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(32, 144);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(277, 144);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 5;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 670);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        internal TextBox PasswordTxtBx;
        internal Label Label1;
        internal Button HashBttn;
        internal Button VerifyHashBttn;
        internal TextBox SaltTxtBx;
        internal TextBox HashedPasswordTxtBx;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal TextBox SaltTesterHPWtxtbx;
        internal TextBox SaltTesterSalttxtbx;
        internal Label Label6;
        internal TextBox SaltTesterPWtxtbx;
        internal Button TestsaltBttn;
        internal Button ConversionButton;
        internal Label Label7;
        internal Label Label8;
        internal TextBox DecryptedHashedPWTextBox;
        internal TextBox DecryptedSaltTextBox;
        internal Label Label9;
        internal TextBox InitialPasswordTextBox;
        internal GroupBox GroupBox1;
        internal GroupBox GroupBox2;
        internal Label Label11;
        internal TextBox BlowfishDecryptedTextBox;
        internal Label Label10;
        internal TextBox BlowfishEncryptedTextBox;
        internal GroupBox GroupBox3;
        internal Label Label12;
        internal TextBox WithSaltBlowfishDecryptPWTextBox;
        internal Label Label13;
        internal TextBox WithSaltBlowfishEncryptTextBox;
        internal Label Label14;
        internal Button WithSaltBlConvertererButton;
        internal TextBox WithSaltPWTextBox;
        internal Label Label15;
        internal TextBox WithSaltTextBox;
        internal Label Label16;
        internal TextBox WithSaltBlowfishHashedPWTextBox;
        private GroupBox groupBox4;
        private TextBox unencypted_pkey_txtbx;
        private TextBox encypted_pkey_txtbx;
        private Label label18;
        private Label label17;
        private Button Encrypt;
        private Button Decrypt;
    }
}