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
            panel1 = new Panel();
            labelArtistNeuDragDropLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtistNeu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelArtistName
            // 
            labelArtistName.AutoSize = true;
            labelArtistName.Location = new Point(9, 9);
            labelArtistName.Name = "labelArtistName";
            labelArtistName.Size = new Size(42, 15);
            labelArtistName.TabIndex = 0;
            labelArtistName.Text = "Name:";
            // 
            // labelBildUpload
            // 
            labelBildUpload.AutoSize = true;
            labelBildUpload.Location = new Point(392, 9);
            labelBildUpload.Name = "labelBildUpload";
            labelBildUpload.Size = new Size(27, 15);
            labelBildUpload.TabIndex = 1;
            labelBildUpload.Text = "Bild";
            // 
            // textBoxNeuerArtist
            // 
            textBoxNeuerArtist.Location = new Point(89, 6);
            textBoxNeuerArtist.Name = "textBoxNeuerArtist";
            textBoxNeuerArtist.Size = new Size(139, 23);
            textBoxNeuerArtist.TabIndex = 2;
            // 
            // labelArtistInfo
            // 
            labelArtistInfo.AutoSize = true;
            labelArtistInfo.Location = new Point(9, 57);
            labelArtistInfo.Name = "labelArtistInfo";
            labelArtistInfo.Size = new Size(62, 15);
            labelArtistInfo.TabIndex = 3;
            labelArtistInfo.Text = "Artist Info:";
            // 
            // pictureBoxArtistNeu
            // 
            pictureBoxArtistNeu.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxArtistNeu.Location = new Point(392, 37);
            pictureBoxArtistNeu.Name = "pictureBoxArtistNeu";
            pictureBoxArtistNeu.Size = new Size(297, 237);
            pictureBoxArtistNeu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxArtistNeu.TabIndex = 4;
            pictureBoxArtistNeu.TabStop = false;
            // 
            // buttonArtistNeuSpeichern
            // 
            buttonArtistNeuSpeichern.ForeColor = Color.Black;
            buttonArtistNeuSpeichern.Location = new Point(271, 286);
            buttonArtistNeuSpeichern.Name = "buttonArtistNeuSpeichern";
            buttonArtistNeuSpeichern.Size = new Size(103, 36);
            buttonArtistNeuSpeichern.TabIndex = 5;
            buttonArtistNeuSpeichern.Text = "Speichern";
            buttonArtistNeuSpeichern.UseVisualStyleBackColor = true;
            buttonArtistNeuSpeichern.Click += buttonArtistNeuSpeichern_Click;
            // 
            // textBoxArtistNeuInfo
            // 
            textBoxArtistNeuInfo.Location = new Point(89, 57);
            textBoxArtistNeuInfo.Multiline = true;
            textBoxArtistNeuInfo.Name = "textBoxArtistNeuInfo";
            textBoxArtistNeuInfo.Size = new Size(285, 167);
            textBoxArtistNeuInfo.TabIndex = 6;
            // 
            // buttonArtistNeuAbbrechen
            // 
            buttonArtistNeuAbbrechen.ForeColor = Color.Black;
            buttonArtistNeuAbbrechen.Location = new Point(9, 286);
            buttonArtistNeuAbbrechen.Name = "buttonArtistNeuAbbrechen";
            buttonArtistNeuAbbrechen.Size = new Size(103, 36);
            buttonArtistNeuAbbrechen.TabIndex = 7;
            buttonArtistNeuAbbrechen.Text = "Abbrechen";
            buttonArtistNeuAbbrechen.UseVisualStyleBackColor = true;
            buttonArtistNeuAbbrechen.Click += buttonArtistNeuAbbrechen_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 43, 48);
            panel1.Controls.Add(labelArtistNeuDragDropLabel);
            panel1.Controls.Add(buttonArtistNeuAbbrechen);
            panel1.Controls.Add(pictureBoxArtistNeu);
            panel1.Controls.Add(textBoxArtistNeuInfo);
            panel1.Controls.Add(buttonArtistNeuSpeichern);
            panel1.Controls.Add(labelArtistInfo);
            panel1.Controls.Add(textBoxNeuerArtist);
            panel1.Controls.Add(labelBildUpload);
            panel1.Controls.Add(labelArtistName);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 339);
            panel1.TabIndex = 8;
            // 
            // labelArtistNeuDragDropLabel
            // 
            labelArtistNeuDragDropLabel.AutoSize = true;
            labelArtistNeuDragDropLabel.Location = new Point(448, 143);
            labelArtistNeuDragDropLabel.Name = "labelArtistNeuDragDropLabel";
            labelArtistNeuDragDropLabel.Size = new Size(192, 15);
            labelArtistNeuDragDropLabel.TabIndex = 8;
            labelArtistNeuDragDropLabel.Text = "Ziehen Sie ein Bild in dieses Fenster";
            // 
            // NeuerArtist
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 363);
            Controls.Add(panel1);
            Name = "NeuerArtist";
            Text = "NeuerArtist";
            DragDrop += NeuerArtist_DragDrop;
            DragEnter += NeuerArtist_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtistNeu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private System.Windows.Forms.Label labelArtistNeuDragDropLabel;
    }
}