namespace StreamingDB
{
    partial class NeuerArtist
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
            labelArtistName = new System.Windows.Forms.Label();
            labelBildUpload = new System.Windows.Forms.Label();
            textBox1 = new TextBox();
            labelArtistInfo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // labelArtistName
            // 
            labelArtistName.AutoSize = true;
            labelArtistName.Location = new Point(24, 24);
            labelArtistName.Name = "labelArtistName";
            labelArtistName.Size = new Size(42, 15);
            labelArtistName.TabIndex = 0;
            labelArtistName.Text = "Name:";
            // 
            // labelBildUpload
            // 
            labelBildUpload.AutoSize = true;
            labelBildUpload.Location = new Point(28, 270);
            labelBildUpload.Name = "labelBildUpload";
            labelBildUpload.Size = new Size(27, 15);
            labelBildUpload.TabIndex = 1;
            labelBildUpload.Text = "Bild";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 2;
            // 
            // labelArtistInfo
            // 
            labelArtistInfo.AutoSize = true;
            labelArtistInfo.Location = new Point(24, 72);
            labelArtistInfo.Name = "labelArtistInfo";
            labelArtistInfo.Size = new Size(62, 15);
            labelArtistInfo.TabIndex = 3;
            labelArtistInfo.Text = "Artist Info:";
            // 
            // NeuerArtist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 611);
            Controls.Add(labelArtistInfo);
            Controls.Add(textBox1);
            Controls.Add(labelBildUpload);
            Controls.Add(labelArtistName);
            Name = "NeuerArtist";
            Text = "NeuerArtist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelBildUpload;
        private TextBox textBox1;
        private System.Windows.Forms.Label labelArtistInfo;
    }
}