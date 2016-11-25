namespace PolybiusPro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptedBox = new System.Windows.Forms.TextBox();
            this.DecryptedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.BoxCleaner = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptedBox
            // 
            this.EncryptedBox.Location = new System.Drawing.Point(12, 46);
            this.EncryptedBox.Multiline = true;
            this.EncryptedBox.Name = "EncryptedBox";
            this.EncryptedBox.Size = new System.Drawing.Size(191, 217);
            this.EncryptedBox.TabIndex = 0;
            // 
            // DecryptedBox
            // 
            this.DecryptedBox.Location = new System.Drawing.Point(283, 46);
            this.DecryptedBox.Multiline = true;
            this.DecryptedBox.Name = "DecryptedBox";
            this.DecryptedBox.Size = new System.Drawing.Size(191, 217);
            this.DecryptedBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "⇔";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(61, 282);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(328, 282);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // BoxCleaner
            // 
            this.BoxCleaner.Location = new System.Drawing.Point(170, 359);
            this.BoxCleaner.Name = "BoxCleaner";
            this.BoxCleaner.Size = new System.Drawing.Size(165, 23);
            this.BoxCleaner.TabIndex = 5;
            this.BoxCleaner.Text = "Clear both boxes";
            this.BoxCleaner.UseVisualStyleBackColor = true;
            this.BoxCleaner.Click += new System.EventHandler(this.BoxCleaner_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "For encrypting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "For decrypting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 78);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Allowed letters:\r\n[a-z],  [A-Z]\r\n[а-я] (ru, ua),  [А-Я] (ru, ua),\r\nNumbers.\r\n~`!" +
    "@#%^&*()+-*/_\\|<>;:?.,[]{}$♂\r\nSpace, carriage return.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxCleaner);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecryptedBox);
            this.Controls.Add(this.EncryptedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EncryptedBox;
        private System.Windows.Forms.TextBox DecryptedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button BoxCleaner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

