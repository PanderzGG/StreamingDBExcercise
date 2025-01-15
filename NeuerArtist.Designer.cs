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
            textBoxNeuerArtist = new TextBox();
            labelArtistInfo = new System.Windows.Forms.Label();
            pictureBoxArtistNeu = new PictureBox();
            buttonArtistNeuSpeichern = new Button();
            textBoxArtistNeuInfo = new TextBox();
            buttonArtistNeuAbbrechen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtistNeu).BeginInit();
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
            labelBildUpload.Location = new Point(362, 24);
            labelBildUpload.Name = "labelBildUpload";
            labelBildUpload.Size = new Size(27, 15);
            labelBildUpload.TabIndex = 1;
            labelBildUpload.Text = "Bild";
            // 
            // textBoxNeuerArtist
            // 
            textBoxNeuerArtist.Location = new Point(104, 21);
            textBoxNeuerArtist.Name = "textBoxNeuerArtist";
            textBoxNeuerArtist.Size = new Size(139, 23);
            textBoxNeuerArtist.TabIndex = 2;
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
            // pictureBoxArtistNeu
            // 
            pictureBoxArtistNeu.Location = new Point(429, 12);
            pictureBoxArtistNeu.Name = "pictureBoxArtistNeu";
            pictureBoxArtistNeu.Size = new Size(224, 227);
            pictureBoxArtistNeu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxArtistNeu.TabIndex = 4;
            pictureBoxArtistNeu.TabStop = false;
            // 
            // buttonArtistNeuSpeichern
            // 
            buttonArtistNeuSpeichern.Location = new Point(550, 275);
            buttonArtistNeuSpeichern.Name = "buttonArtistNeuSpeichern";
            buttonArtistNeuSpeichern.Size = new Size(103, 36);
            buttonArtistNeuSpeichern.TabIndex = 5;
            buttonArtistNeuSpeichern.Text = "Speichern";
            buttonArtistNeuSpeichern.UseVisualStyleBackColor = true;
            buttonArtistNeuSpeichern.Click += buttonArtistNeuSpeichern_Click;
            // 
            // textBoxArtistNeuInfo
            // 
            textBoxArtistNeuInfo.Location = new Point(104, 72);
            textBoxArtistNeuInfo.Multiline = true;
            textBoxArtistNeuInfo.Name = "textBoxArtistNeuInfo";
            textBoxArtistNeuInfo.Size = new Size(285, 167);
            textBoxArtistNeuInfo.TabIndex = 6;
            // 
            // buttonArtistNeuAbbrechen
            // 
            buttonArtistNeuAbbrechen.Location = new Point(362, 275);
            buttonArtistNeuAbbrechen.Name = "buttonArtistNeuAbbrechen";
            buttonArtistNeuAbbrechen.Size = new Size(103, 36);
            buttonArtistNeuAbbrechen.TabIndex = 7;
            buttonArtistNeuAbbrechen.Text = "Abbrechen";
            buttonArtistNeuAbbrechen.UseVisualStyleBackColor = true;
            buttonArtistNeuAbbrechen.Click += buttonArtistNeuAbbrechen_Click;
            // 
            // NeuerArtist
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 363);
            Controls.Add(buttonArtistNeuAbbrechen);
            Controls.Add(textBoxArtistNeuInfo);
            Controls.Add(buttonArtistNeuSpeichern);
            Controls.Add(pictureBoxArtistNeu);
            Controls.Add(labelArtistInfo);
            Controls.Add(textBoxNeuerArtist);
            Controls.Add(labelBildUpload);
            Controls.Add(labelArtistName);
            Name = "NeuerArtist";
            Text = "NeuerArtist";
            DragDrop += NeuerArtist_DragDrop;
            DragEnter += NeuerArtist_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtistNeu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelBildUpload;
        private TextBox textBoxNeuerArtist;
        private System.Windows.Forms.Label labelArtistInfo;
        private PictureBox pictureBoxArtistNeu;
        private Button buttonArtistNeuSpeichern;
        private TextBox textBoxArtistNeuInfo;
        private Button buttonArtistNeuAbbrechen;
    }
}