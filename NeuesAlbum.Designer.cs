namespace StreamingDB
{
    partial class NeuesAlbum
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
            tabControlAlbumNeu = new TabControl();
            tabPageNeuesAlbum = new TabPage();
            buttonAlbumAbbrechenNeu = new Button();
            buttonAlbumNeuNaechsteSeite = new Button();
            comboBoxAlbumGenreNeu = new ComboBox();
            labelAlbumGenreNeu = new System.Windows.Forms.Label();
            labelAlbumCoverNeu = new System.Windows.Forms.Label();
            pictureBoxAlbumNeu = new PictureBox();
            comboBoxAlbumLabelNeu = new ComboBox();
            comboBoxAlbumArtistNeu = new ComboBox();
            numericUpDownAlbumErschJahrNeu = new NumericUpDown();
            textBoxAlbumAlbumNeu = new TextBox();
            labelAlbumLabelNeu = new System.Windows.Forms.Label();
            labelAlbumArtistNeu = new System.Windows.Forms.Label();
            labelAlbumErscheinungsjahrNeu = new System.Windows.Forms.Label();
            labelAlbumNameNeu = new System.Windows.Forms.Label();
            tabPageSongs = new TabPage();
            buttonAlbumSongZurueck = new Button();
            buttonAlbumSpeichern = new Button();
            labelAlbumTracklistNeu = new System.Windows.Forms.Label();
            dataGridViewTracklist = new DataGridView();
            trackListTitel = new DataGridViewTextBoxColumn();
            trackListDauer = new DataGridViewTextBoxColumn();
            trackListBPM = new DataGridViewTextBoxColumn();
            trackListFormat = new DataGridViewTextBoxColumn();
            tabControlAlbumNeu.SuspendLayout();
            tabPageNeuesAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumNeu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlbumErschJahrNeu).BeginInit();
            tabPageSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTracklist).BeginInit();
            SuspendLayout();
            // 
            // tabControlAlbumNeu
            // 
            tabControlAlbumNeu.Controls.Add(tabPageNeuesAlbum);
            tabControlAlbumNeu.Controls.Add(tabPageSongs);
            tabControlAlbumNeu.Location = new Point(12, 12);
            tabControlAlbumNeu.Name = "tabControlAlbumNeu";
            tabControlAlbumNeu.SelectedIndex = 0;
            tabControlAlbumNeu.Size = new Size(635, 426);
            tabControlAlbumNeu.TabIndex = 0;
            // 
            // tabPageNeuesAlbum
            // 
            tabPageNeuesAlbum.AllowDrop = true;
            tabPageNeuesAlbum.Controls.Add(buttonAlbumAbbrechenNeu);
            tabPageNeuesAlbum.Controls.Add(buttonAlbumNeuNaechsteSeite);
            tabPageNeuesAlbum.Controls.Add(comboBoxAlbumGenreNeu);
            tabPageNeuesAlbum.Controls.Add(labelAlbumGenreNeu);
            tabPageNeuesAlbum.Controls.Add(labelAlbumCoverNeu);
            tabPageNeuesAlbum.Controls.Add(pictureBoxAlbumNeu);
            tabPageNeuesAlbum.Controls.Add(comboBoxAlbumLabelNeu);
            tabPageNeuesAlbum.Controls.Add(comboBoxAlbumArtistNeu);
            tabPageNeuesAlbum.Controls.Add(numericUpDownAlbumErschJahrNeu);
            tabPageNeuesAlbum.Controls.Add(textBoxAlbumAlbumNeu);
            tabPageNeuesAlbum.Controls.Add(labelAlbumLabelNeu);
            tabPageNeuesAlbum.Controls.Add(labelAlbumArtistNeu);
            tabPageNeuesAlbum.Controls.Add(labelAlbumErscheinungsjahrNeu);
            tabPageNeuesAlbum.Controls.Add(labelAlbumNameNeu);
            tabPageNeuesAlbum.Location = new Point(4, 24);
            tabPageNeuesAlbum.Name = "tabPageNeuesAlbum";
            tabPageNeuesAlbum.Padding = new Padding(3);
            tabPageNeuesAlbum.Size = new Size(627, 398);
            tabPageNeuesAlbum.TabIndex = 0;
            tabPageNeuesAlbum.Text = "Album";
            tabPageNeuesAlbum.UseVisualStyleBackColor = true;
            tabPageNeuesAlbum.DragDrop += tabPageNeuesAlbum_DragDrop;
            tabPageNeuesAlbum.DragEnter += tabPageNeuesAlbum_DragEnter;
            // 
            // buttonAlbumAbbrechenNeu
            // 
            buttonAlbumAbbrechenNeu.Location = new Point(6, 297);
            buttonAlbumAbbrechenNeu.Name = "buttonAlbumAbbrechenNeu";
            buttonAlbumAbbrechenNeu.Size = new Size(138, 35);
            buttonAlbumAbbrechenNeu.TabIndex = 13;
            buttonAlbumAbbrechenNeu.Text = "Abbrechen";
            buttonAlbumAbbrechenNeu.UseVisualStyleBackColor = true;
            buttonAlbumAbbrechenNeu.Click += buttonAlbumAbbrechenNeu_Click;
            // 
            // buttonAlbumNeuNaechsteSeite
            // 
            buttonAlbumNeuNaechsteSeite.Location = new Point(483, 297);
            buttonAlbumNeuNaechsteSeite.Name = "buttonAlbumNeuNaechsteSeite";
            buttonAlbumNeuNaechsteSeite.Size = new Size(138, 35);
            buttonAlbumNeuNaechsteSeite.TabIndex = 12;
            buttonAlbumNeuNaechsteSeite.Text = "Nächste Seite";
            buttonAlbumNeuNaechsteSeite.UseVisualStyleBackColor = true;
            buttonAlbumNeuNaechsteSeite.Click += buttonAlbumNeuNaechsteSeite_Click;
            // 
            // comboBoxAlbumGenreNeu
            // 
            comboBoxAlbumGenreNeu.FormattingEnabled = true;
            comboBoxAlbumGenreNeu.Location = new Point(142, 152);
            comboBoxAlbumGenreNeu.Name = "comboBoxAlbumGenreNeu";
            comboBoxAlbumGenreNeu.Size = new Size(131, 23);
            comboBoxAlbumGenreNeu.TabIndex = 11;
            // 
            // labelAlbumGenreNeu
            // 
            labelAlbumGenreNeu.AutoSize = true;
            labelAlbumGenreNeu.Location = new Point(6, 155);
            labelAlbumGenreNeu.Name = "labelAlbumGenreNeu";
            labelAlbumGenreNeu.Size = new Size(41, 15);
            labelAlbumGenreNeu.TabIndex = 10;
            labelAlbumGenreNeu.Text = "Genre:";
            // 
            // labelAlbumCoverNeu
            // 
            labelAlbumCoverNeu.AutoSize = true;
            labelAlbumCoverNeu.Location = new Point(338, 8);
            labelAlbumCoverNeu.Name = "labelAlbumCoverNeu";
            labelAlbumCoverNeu.Size = new Size(80, 15);
            labelAlbumCoverNeu.TabIndex = 9;
            labelAlbumCoverNeu.Text = "Album Cover:";
            // 
            // pictureBoxAlbumNeu
            // 
            pictureBoxAlbumNeu.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxAlbumNeu.Location = new Point(338, 26);
            pictureBoxAlbumNeu.Name = "pictureBoxAlbumNeu";
            pictureBoxAlbumNeu.Size = new Size(283, 228);
            pictureBoxAlbumNeu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlbumNeu.TabIndex = 8;
            pictureBoxAlbumNeu.TabStop = false;
            // 
            // comboBoxAlbumLabelNeu
            // 
            comboBoxAlbumLabelNeu.FormattingEnabled = true;
            comboBoxAlbumLabelNeu.Location = new Point(142, 195);
            comboBoxAlbumLabelNeu.Name = "comboBoxAlbumLabelNeu";
            comboBoxAlbumLabelNeu.Size = new Size(131, 23);
            comboBoxAlbumLabelNeu.TabIndex = 7;
            // 
            // comboBoxAlbumArtistNeu
            // 
            comboBoxAlbumArtistNeu.FormattingEnabled = true;
            comboBoxAlbumArtistNeu.Location = new Point(142, 113);
            comboBoxAlbumArtistNeu.Name = "comboBoxAlbumArtistNeu";
            comboBoxAlbumArtistNeu.Size = new Size(131, 23);
            comboBoxAlbumArtistNeu.TabIndex = 6;
            // 
            // numericUpDownAlbumErschJahrNeu
            // 
            numericUpDownAlbumErschJahrNeu.Location = new Point(142, 73);
            numericUpDownAlbumErschJahrNeu.Maximum = new decimal(new int[] { 3500, 0, 0, 0 });
            numericUpDownAlbumErschJahrNeu.Name = "numericUpDownAlbumErschJahrNeu";
            numericUpDownAlbumErschJahrNeu.Size = new Size(131, 23);
            numericUpDownAlbumErschJahrNeu.TabIndex = 5;
            numericUpDownAlbumErschJahrNeu.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // textBoxAlbumAlbumNeu
            // 
            textBoxAlbumAlbumNeu.Location = new Point(142, 26);
            textBoxAlbumAlbumNeu.Name = "textBoxAlbumAlbumNeu";
            textBoxAlbumAlbumNeu.Size = new Size(131, 23);
            textBoxAlbumAlbumNeu.TabIndex = 4;
            // 
            // labelAlbumLabelNeu
            // 
            labelAlbumLabelNeu.AutoSize = true;
            labelAlbumLabelNeu.Location = new Point(6, 197);
            labelAlbumLabelNeu.Name = "labelAlbumLabelNeu";
            labelAlbumLabelNeu.Size = new Size(35, 15);
            labelAlbumLabelNeu.TabIndex = 3;
            labelAlbumLabelNeu.Text = "Label";
            // 
            // labelAlbumArtistNeu
            // 
            labelAlbumArtistNeu.AutoSize = true;
            labelAlbumArtistNeu.Location = new Point(6, 113);
            labelAlbumArtistNeu.Name = "labelAlbumArtistNeu";
            labelAlbumArtistNeu.Size = new Size(38, 15);
            labelAlbumArtistNeu.TabIndex = 2;
            labelAlbumArtistNeu.Text = "Artist:";
            // 
            // labelAlbumErscheinungsjahrNeu
            // 
            labelAlbumErscheinungsjahrNeu.AutoSize = true;
            labelAlbumErscheinungsjahrNeu.Location = new Point(6, 71);
            labelAlbumErscheinungsjahrNeu.Name = "labelAlbumErscheinungsjahrNeu";
            labelAlbumErscheinungsjahrNeu.Size = new Size(100, 15);
            labelAlbumErscheinungsjahrNeu.TabIndex = 1;
            labelAlbumErscheinungsjahrNeu.Text = "Erscheinungsjahr:";
            // 
            // labelAlbumNameNeu
            // 
            labelAlbumNameNeu.AutoSize = true;
            labelAlbumNameNeu.Location = new Point(6, 29);
            labelAlbumNameNeu.Name = "labelAlbumNameNeu";
            labelAlbumNameNeu.Size = new Size(81, 15);
            labelAlbumNameNeu.TabIndex = 0;
            labelAlbumNameNeu.Text = "Album Name:";
            // 
            // tabPageSongs
            // 
            tabPageSongs.Controls.Add(buttonAlbumSongZurueck);
            tabPageSongs.Controls.Add(buttonAlbumSpeichern);
            tabPageSongs.Controls.Add(labelAlbumTracklistNeu);
            tabPageSongs.Controls.Add(dataGridViewTracklist);
            tabPageSongs.Location = new Point(4, 24);
            tabPageSongs.Name = "tabPageSongs";
            tabPageSongs.Padding = new Padding(3);
            tabPageSongs.Size = new Size(627, 398);
            tabPageSongs.TabIndex = 1;
            tabPageSongs.Text = "Songs";
            tabPageSongs.UseVisualStyleBackColor = true;
            // 
            // buttonAlbumSongZurueck
            // 
            buttonAlbumSongZurueck.Location = new Point(6, 358);
            buttonAlbumSongZurueck.Name = "buttonAlbumSongZurueck";
            buttonAlbumSongZurueck.Size = new Size(114, 29);
            buttonAlbumSongZurueck.TabIndex = 3;
            buttonAlbumSongZurueck.Text = "Zurück";
            buttonAlbumSongZurueck.UseVisualStyleBackColor = true;
            buttonAlbumSongZurueck.Click += buttonAlbumSongZurueck_Click;
            // 
            // buttonAlbumSpeichern
            // 
            buttonAlbumSpeichern.Location = new Point(507, 358);
            buttonAlbumSpeichern.Name = "buttonAlbumSpeichern";
            buttonAlbumSpeichern.Size = new Size(114, 29);
            buttonAlbumSpeichern.TabIndex = 2;
            buttonAlbumSpeichern.Text = "Speichern";
            buttonAlbumSpeichern.UseVisualStyleBackColor = true;
            buttonAlbumSpeichern.Click += buttonAlbumSpeichern_Click;
            // 
            // labelAlbumTracklistNeu
            // 
            labelAlbumTracklistNeu.AutoSize = true;
            labelAlbumTracklistNeu.Location = new Point(6, 34);
            labelAlbumTracklistNeu.Name = "labelAlbumTracklistNeu";
            labelAlbumTracklistNeu.Size = new Size(55, 15);
            labelAlbumTracklistNeu.TabIndex = 1;
            labelAlbumTracklistNeu.Text = "Tracklist: ";
            // 
            // dataGridViewTracklist
            // 
            dataGridViewTracklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTracklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTracklist.Columns.AddRange(new DataGridViewColumn[] { trackListTitel, trackListDauer, trackListBPM, trackListFormat });
            dataGridViewTracklist.Location = new Point(6, 52);
            dataGridViewTracklist.MultiSelect = false;
            dataGridViewTracklist.Name = "dataGridViewTracklist";
            dataGridViewTracklist.Size = new Size(615, 292);
            dataGridViewTracklist.TabIndex = 0;
            // 
            // trackListTitel
            // 
            trackListTitel.HeaderText = "Titel";
            trackListTitel.Name = "trackListTitel";
            // 
            // trackListDauer
            // 
            trackListDauer.HeaderText = "Dauer";
            trackListDauer.Name = "trackListDauer";
            // 
            // trackListBPM
            // 
            trackListBPM.HeaderText = "BPM";
            trackListBPM.Name = "trackListBPM";
            // 
            // trackListFormat
            // 
            trackListFormat.HeaderText = "Format";
            trackListFormat.Name = "trackListFormat";
            trackListFormat.Resizable = DataGridViewTriState.True;
            // 
            // NeuesAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 450);
            Controls.Add(tabControlAlbumNeu);
            Name = "NeuesAlbum";
            Text = "NeuesAlbum";
            tabControlAlbumNeu.ResumeLayout(false);
            tabPageNeuesAlbum.ResumeLayout(false);
            tabPageNeuesAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumNeu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlbumErschJahrNeu).EndInit();
            tabPageSongs.ResumeLayout(false);
            tabPageSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTracklist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAlbumNeu;
        private TabPage tabPageNeuesAlbum;
        private TabPage tabPageSongs;
        private System.Windows.Forms.Label labelAlbumNameNeu;
        private System.Windows.Forms.Label labelAlbumArtistNeu;
        private System.Windows.Forms.Label labelAlbumErscheinungsjahrNeu;
        private System.Windows.Forms.Label labelAlbumLabelNeu;
        private System.Windows.Forms.Label labelAlbumCoverNeu;
        private PictureBox pictureBoxAlbumNeu;
        private ComboBox comboBoxAlbumLabelNeu;
        private ComboBox comboBoxAlbumArtistNeu;
        private NumericUpDown numericUpDownAlbumErschJahrNeu;
        private TextBox textBoxAlbumAlbumNeu;
        private System.Windows.Forms.Label labelAlbumTracklistNeu;
        private DataGridView dataGridViewTracklist;
        private System.Windows.Forms.Label labelAlbumGenreNeu;
        private Button buttonAlbumAbbrechenNeu;
        private Button buttonAlbumNeuNaechsteSeite;
        private ComboBox comboBoxAlbumGenreNeu;
        private Button buttonAlbumSpeichern;
        private Button buttonAlbumSongZurueck;
        private DataGridViewTextBoxColumn trackListTitel;
        private DataGridViewTextBoxColumn trackListDauer;
        private DataGridViewTextBoxColumn trackListBPM;
        private DataGridViewTextBoxColumn trackListFormat;
    }
}