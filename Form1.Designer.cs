namespace HashApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openedFileTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptedFileTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.selectEncryptionMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.encryptionLabel = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.savedFilePath = new System.Windows.Forms.Label();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RsaPrivateKeyLabel = new System.Windows.Forms.Label();
            this.GenerateRSAPrivateKey = new System.Windows.Forms.Button();
            this.GetRSAKeyLabel = new System.Windows.Forms.Label();
            this.OpenPrivateRSAKey = new System.Windows.Forms.Button();
            this.RSAPrivateKeyPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openedFileTextBox
            // 
            this.openedFileTextBox.Location = new System.Drawing.Point(36, 56);
            this.openedFileTextBox.Name = "openedFileTextBox";
            this.openedFileTextBox.ReadOnly = true;
            this.openedFileTextBox.Size = new System.Drawing.Size(245, 364);
            this.openedFileTextBox.TabIndex = 0;
            this.openedFileTextBox.Text = "";
            // 
            // encryptedFileTextBox
            // 
            this.encryptedFileTextBox.Location = new System.Drawing.Point(665, 56);
            this.encryptedFileTextBox.Name = "encryptedFileTextBox";
            this.encryptedFileTextBox.ReadOnly = true;
            this.encryptedFileTextBox.Size = new System.Drawing.Size(245, 364);
            this.encryptedFileTextBox.TabIndex = 1;
            this.encryptedFileTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "wczytany plik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "przetworzony plik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "wczytaj plik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectEncryptionMethod
            // 
            this.selectEncryptionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectEncryptionMethod.Items.AddRange(new object[] {
            "metoda_1",
            "metoda_2"});
            this.selectEncryptionMethod.Location = new System.Drawing.Point(312, 167);
            this.selectEncryptionMethod.Name = "selectEncryptionMethod";
            this.selectEncryptionMethod.Size = new System.Drawing.Size(121, 23);
            this.selectEncryptionMethod.TabIndex = 5;
            this.selectEncryptionMethod.SelectedIndexChanged += new System.EventHandler(this.selectEncryptionMethod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "metoda szyfrowania:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "zapisz do pliku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // encryptionButton
            // 
            this.encryptionButton.Enabled = false;
            this.encryptionButton.Location = new System.Drawing.Point(484, 149);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(121, 23);
            this.encryptionButton.TabIndex = 8;
            this.encryptionButton.Text = "szyfruj";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // encryptionLabel
            // 
            this.encryptionLabel.AutoSize = true;
            this.encryptionLabel.Location = new System.Drawing.Point(312, 69);
            this.encryptionLabel.Name = "encryptionLabel";
            this.encryptionLabel.Size = new System.Drawing.Size(132, 15);
            this.encryptionLabel.TabIndex = 9;
            this.encryptionLabel.Text = "Twojj klucz szyfrowania:";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(312, 87);
            this.key.MinimumSize = new System.Drawing.Size(8, 4);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(326, 23);
            this.key.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sciezka do zapisanego pliku:";
            // 
            // savedFilePath
            // 
            this.savedFilePath.AutoSize = true;
            this.savedFilePath.Location = new System.Drawing.Point(665, 494);
            this.savedFilePath.Name = "savedFilePath";
            this.savedFilePath.Size = new System.Drawing.Size(0, 15);
            this.savedFilePath.TabIndex = 12;
            // 
            // decryptionButton
            // 
            this.decryptionButton.Enabled = false;
            this.decryptionButton.Location = new System.Drawing.Point(484, 187);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(121, 23);
            this.decryptionButton.TabIndex = 13;
            this.decryptionButton.Text = "deszyfruj";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 14;
            // 
            // RsaPrivateKeyLabel
            // 
            this.RsaPrivateKeyLabel.AutoSize = true;
            this.RsaPrivateKeyLabel.Location = new System.Drawing.Point(310, 254);
            this.RsaPrivateKeyLabel.Name = "RsaPrivateKeyLabel";
            this.RsaPrivateKeyLabel.Size = new System.Drawing.Size(114, 15);
            this.RsaPrivateKeyLabel.TabIndex = 16;
            this.RsaPrivateKeyLabel.Text = "Klucz prywatny RSA:";
            this.RsaPrivateKeyLabel.Visible = false;
            // 
            // GenerateRSAPrivateKey
            // 
            this.GenerateRSAPrivateKey.Location = new System.Drawing.Point(327, 289);
            this.GenerateRSAPrivateKey.Name = "GenerateRSAPrivateKey";
            this.GenerateRSAPrivateKey.Size = new System.Drawing.Size(75, 23);
            this.GenerateRSAPrivateKey.TabIndex = 17;
            this.GenerateRSAPrivateKey.Text = "generuj";
            this.GenerateRSAPrivateKey.UseVisualStyleBackColor = true;
            this.GenerateRSAPrivateKey.Visible = false;
            this.GenerateRSAPrivateKey.Click += new System.EventHandler(this.GenerateRSAPrivateKey_Click);
            // 
            // GetRSAKeyLabel
            // 
            this.GetRSAKeyLabel.AutoSize = true;
            this.GetRSAKeyLabel.Location = new System.Drawing.Point(464, 254);
            this.GetRSAKeyLabel.Name = "GetRSAKeyLabel";
            this.GetRSAKeyLabel.Size = new System.Drawing.Size(157, 15);
            this.GetRSAKeyLabel.TabIndex = 18;
            this.GetRSAKeyLabel.Text = "Wczytaj klucz prywatny RSA:";
            this.GetRSAKeyLabel.Visible = false;
            // 
            // OpenPrivateRSAKey
            // 
            this.OpenPrivateRSAKey.Location = new System.Drawing.Point(502, 289);
            this.OpenPrivateRSAKey.Name = "OpenPrivateRSAKey";
            this.OpenPrivateRSAKey.Size = new System.Drawing.Size(75, 23);
            this.OpenPrivateRSAKey.TabIndex = 19;
            this.OpenPrivateRSAKey.Text = "wczytaj";
            this.OpenPrivateRSAKey.UseVisualStyleBackColor = true;
            this.OpenPrivateRSAKey.Visible = false;
            this.OpenPrivateRSAKey.Click += new System.EventHandler(this.OpenPrivateRSAKey_Click);
            // 
            // RSAPrivateKeyPathLabel
            // 
            this.RSAPrivateKeyPathLabel.AutoSize = true;
            this.RSAPrivateKeyPathLabel.Location = new System.Drawing.Point(309, 228);
            this.RSAPrivateKeyPathLabel.Name = "RSAPrivateKeyPathLabel";
            this.RSAPrivateKeyPathLabel.Size = new System.Drawing.Size(0, 15);
            this.RSAPrivateKeyPathLabel.TabIndex = 20;
            this.RSAPrivateKeyPathLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 563);
            this.Controls.Add(this.RSAPrivateKeyPathLabel);
            this.Controls.Add(this.OpenPrivateRSAKey);
            this.Controls.Add(this.GetRSAKeyLabel);
            this.Controls.Add(this.GenerateRSAPrivateKey);
            this.Controls.Add(this.RsaPrivateKeyLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.savedFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.key);
            this.Controls.Add(this.encryptionLabel);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectEncryptionMethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptedFileTextBox);
            this.Controls.Add(this.openedFileTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox encryptedFileTextBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox selectEncryptionMethod;
        private Label label3;
        private Button button2;
        private Button encryptionButton;
        private RichTextBox openedFileTextBox;
        private Label encryptionLabel;
        private TextBox key;
        private Label label5;
        private Label savedFilePath;
        private Button decryptionButton;
        private Label label6;
        private Label RsaPrivateKeyLabel;
        private Button GenerateRSAPrivateKey;
        private Label GetRSAKeyLabel;
        private Button OpenPrivateRSAKey;
        private Label RSAPrivateKeyPathLabel;
    }
}