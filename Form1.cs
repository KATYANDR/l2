using EncryptionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ResultTxt : Form
    {
        public ResultTxt()
        {
            InitializeComponent();

        }
        // some update

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtPlainText.Text;
            string salt = txtSalt.Text;

            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(salt))
            {
                MessageBox.Show("Пожалуйста, введите текст и соль.");
                return;
            }

            string encryptedText = Encryptor.EncryptString(plainText, salt);
            txtResult.Text = encryptedText;
        }

    private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtResult.Text;
            string salt = txtSalt.Text;

            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(salt))
            {
                MessageBox.Show("Пожалуйста, введите зашифрованный текст и соль.");
                return;
            }

            try
            {
                string decryptedText = Encryptor.DecryptString(cipherText, salt);
                txtPlainText.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расшифровке: " + ex.Message);
            }
        }

    }
}
