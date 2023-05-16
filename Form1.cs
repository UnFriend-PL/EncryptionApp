using System.Security.Cryptography;
namespace HashApp
{
    public partial class Form1 : Form
    {
        string fileContent = string.Empty;
        string encryptetFileContent;
        string filePath = string.Empty;
        string RsaKey = string.Empty;
        string RSAPrivateKeyPath = "";

        public Form1()
        {
            InitializeComponent();
            selectEncryptionMethod.DataSource = Enum.GetValues(typeof(EncryptionMethods));
            savedFilePath.Text = Encryption.initialDirectory;
            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.KeySize = 128;
                aesAlgorithm.GenerateKey();
                string keyBase64 = Convert.ToBase64String(aesAlgorithm.Key);
                key.Text = keyBase64;
            }
            RsaPrivateKeyLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Encryption.initialDirectory;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            openedFileTextBox.Text = fileContent;
            CheckFileIsOpenAllowSelectEncryption();
        }

        private void CheckFileIsOpenAllowSelectEncryption()
        {
            if (fileContent != string.Empty && key.Text != string.Empty)
            {
                encryptionButton.Enabled = true;
                decryptionButton.Enabled = true;
            }
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            EncryptionMethods selectedMethod;
            try
            {
                selectedMethod = (EncryptionMethods)selectEncryptionMethod.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybrano niepoprawna metode szyfrowania!");
                return;
            }
            if (selectedMethod == EncryptionMethods.AES)
            {
                encryptetFileContent = Encryption.EncryptAESFile(fileContent, key.Text);
                encryptedFileTextBox.Text = encryptetFileContent;

            }
            if (selectedMethod == EncryptionMethods.RSA)
            {
                if (RSAPrivateKeyPathLabel.Text == "")
                {
                    MessageBox.Show("Wczytaj lub wygeneruj klucz prywatny!");
                    return;
                }
                encryptionButton.Enabled = true;
                decryptionButton.Enabled = true;
                var rsaCryptoServiceProvider = Encryption.ReadPrivateKeyFromFile(RSAPrivateKeyPath);
                encryptetFileContent = Encryption.EncryptRSAFile(fileContent, rsaCryptoServiceProvider.ExportParameters(false));
                encryptedFileTextBox.Text = encryptetFileContent;
                RsaKey = rsaCryptoServiceProvider.ToString();
                key.Text = RsaKey;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Encryption.initialDirectory;
            saveFileDialog1.Title = Encryption.encryptedFileName;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FileName = Encryption.encryptedFileName;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savedFilePath.Text = saveFileDialog1.FileName;
            }
            if (savedFilePath.Text != Encryption.initialDirectory)
            {
                File.WriteAllTextAsync(savedFilePath.Text, encryptetFileContent);
                MessageBox.Show("Zapisano!");
            }
        }
        private void decryptionButton_Click(object sender, EventArgs e)
        {
            EncryptionMethods selectedMethod;
            try
            {
                selectedMethod = (EncryptionMethods)selectEncryptionMethod.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybrano niepoprawna metode szyfrowania!");
                return;
            }
            if (selectedMethod == EncryptionMethods.AES)
            {
                encryptetFileContent = Encryption.DecryptAESFile(openedFileTextBox.Text, key.Text);
                encryptedFileTextBox.Text = encryptetFileContent;
            }
            else if (selectedMethod == EncryptionMethods.RSA)
            {
                var rsaCryptoServiceProvider = Encryption.ReadPrivateKeyFromFile(RSAPrivateKeyPath);
                encryptetFileContent = Encryption.DecryptRSAFile(fileContent, rsaCryptoServiceProvider.ExportParameters(true));
                encryptedFileTextBox.Text = encryptetFileContent;
            }
        }

        private void selectEncryptionMethod_TextChanged(object sender, EventArgs e)
        {
            EncryptionMethods selectedMethod;
            try
            {
                selectedMethod = (EncryptionMethods)selectEncryptionMethod.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybrano niepoprawna metode szyfrowania!");
                return;
            }
            if (selectedMethod == EncryptionMethods.AES)
            {
                encryptionLabel.Text = "Twoj klucz szyfrowania AES:";
                RsaPrivateKeyLabel.Visible = false;
                GenerateRSAPrivateKey.Visible = false;
                GetRSAKeyLabel.Visible = false;
                OpenPrivateRSAKey.Visible = false;
                RSAPrivateKeyPathLabel.Visible = false;
                using (Aes aesAlgorithm = Aes.Create())
                {
                    encryptionLabel.Visible = true;
                    aesAlgorithm.KeySize = 128;
                    aesAlgorithm.GenerateKey();
                    string keyBase64 = Convert.ToBase64String(aesAlgorithm.Key);
                    key.Text = keyBase64;
                    key.Visible = true;

                }
            }
            if (selectedMethod == EncryptionMethods.RSA)
            {
                RsaPrivateKeyLabel.Visible = true;
                GenerateRSAPrivateKey.Visible = true;
                GetRSAKeyLabel.Visible = true;
                OpenPrivateRSAKey.Visible = true;
                RSAPrivateKeyPathLabel.Visible = true;
                key.Visible = false;
                encryptionLabel.Visible = false;
            }

        }

        private void GenerateRSAPrivateKey_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Encryption.initialDirectory;
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog1.FileName = "myprivatekey.xml";
            saveFileDialog1.Title = "Save Private Key";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string privateKey = Encryption.GenerateRSAPrivateKey();
                File.WriteAllText(saveFileDialog1.FileName, privateKey);
                RSAPrivateKeyPath = saveFileDialog1.FileName;
                MessageBox.Show("Private key saved successfully!");
                RSAPrivateKeyPathLabel.Text = RSAPrivateKeyPath;
            }
        }

        private void OpenPrivateRSAKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Encryption.initialDirectory;
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RSAPrivateKeyPath = openFileDialog.FileName;
                    RSAPrivateKeyPathLabel.Text = RSAPrivateKeyPath;

                }
            }
        }
    }
}