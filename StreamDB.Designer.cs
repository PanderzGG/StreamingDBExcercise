namespace StreamingDB
{
    partial class StreamDB
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
            tabControlOverview = new TabControl();
            tabPageOverview = new TabPage();
            labelGenreWert = new System.Windows.Forms.Label();
            labelGenre = new System.Windows.Forms.Label();
            buttonLabelDetail = new Button();
            buttonArtistAnzeigen = new Button();
            buttonAlbumAnzeigen = new Button();
            labelFormatWert = new System.Windows.Forms.Label();
            labelLabelWert = new System.Windows.Forms.Label();
            comboBoxAlben = new ComboBox();
            comboBoxArtist = new ComboBox();
            labelLabel = new System.Windows.Forms.Label();
            labelFormat = new System.Windows.Forms.Label();
            dataGridViewAlbumTrackList = new DataGridView();
            songNr = new DataGridViewTextBoxColumn();
            songTitel = new DataGridViewTextBoxColumn();
            songDauer = new DataGridViewTextBoxColumn();
            songFeat = new DataGridViewTextBoxColumn();
            labelSongs = new System.Windows.Forms.Label();
            labelAlben = new System.Windows.Forms.Label();
            labelArtist = new System.Windows.Forms.Label();
            tabPageAlbumDetail = new TabPage();
            textBoxAlbumInfo = new TextBox();
            labelAlbumGenre = new System.Windows.Forms.Label();
            dataGridViewAlbumSongList = new DataGridView();
            albumSongNummer = new DataGridViewTextBoxColumn();
            albumSongTitel = new DataGridViewTextBoxColumn();
            albumSongDauer = new DataGridViewTextBoxColumn();
            albumSongBPM = new DataGridViewTextBoxColumn();
            albumSongFormat = new DataGridViewTextBoxColumn();
            labelAlbumAlbum = new System.Windows.Forms.Label();
            pictureBoxAlbum = new PictureBox();
            labelAlbumArtist = new System.Windows.Forms.Label();
            tabPageArtistDetail = new TabPage();
            textBoxArtistInfo = new TextBox();
            pictureBoxArtist = new PictureBox();
            labelArtistArtist = new System.Windows.Forms.Label();
            tabPageLabelDetail = new TabPage();
            textBoxLabelInfo = new TextBox();
            labelLabelLabel = new System.Windows.Forms.Label();
            buttonNewArtist = new Button();
            tabControlOverview.SuspendLayout();
            tabPageOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbumTrackList).BeginInit();
            tabPageAlbumDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbumSongList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).BeginInit();
            tabPageArtistDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtist).BeginInit();
            tabPageLabelDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlOverview
            // 
            tabControlOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlOverview.Controls.Add(tabPageOverview);
            tabControlOverview.Controls.Add(tabPageAlbumDetail);
            tabControlOverview.Controls.Add(tabPageArtistDetail);
            tabControlOverview.Controls.Add(tabPageLabelDetail);
            tabControlOverview.Location = new Point(12, 12);
            tabControlOverview.Name = "tabControlOverview";
            tabControlOverview.SelectedIndex = 0;
            tabControlOverview.Size = new Size(899, 693);
            tabControlOverview.TabIndex = 0;
            tabControlOverview.SelectedIndexChanged += tabControlOverview_SelectedIndexChanged;
            // 
            // tabPageOverview
            // 
            tabPageOverview.Controls.Add(buttonNewArtist);
            tabPageOverview.Controls.Add(labelGenreWert);
            tabPageOverview.Controls.Add(labelGenre);
            tabPageOverview.Controls.Add(buttonLabelDetail);
            tabPageOverview.Controls.Add(buttonArtistAnzeigen);
            tabPageOverview.Controls.Add(buttonAlbumAnzeigen);
            tabPageOverview.Controls.Add(labelFormatWert);
            tabPageOverview.Controls.Add(labelLabelWert);
            tabPageOverview.Controls.Add(comboBoxAlben);
            tabPageOverview.Controls.Add(comboBoxArtist);
            tabPageOverview.Controls.Add(labelLabel);
            tabPageOverview.Controls.Add(labelFormat);
            tabPageOverview.Controls.Add(dataGridViewAlbumTrackList);
            tabPageOverview.Controls.Add(labelSongs);
            tabPageOverview.Controls.Add(labelAlben);
            tabPageOverview.Controls.Add(labelArtist);
            tabPageOverview.Location = new Point(4, 24);
            tabPageOverview.Name = "tabPageOverview";
            tabPageOverview.Padding = new Padding(3);
            tabPageOverview.Size = new Size(891, 665);
            tabPageOverview.TabIndex = 0;
            tabPageOverview.Text = "Übersicht";
            tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // labelGenreWert
            // 
            labelGenreWert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGenreWert.AutoSize = true;
            labelGenreWert.Location = new Point(128, 232);
            labelGenreWert.Name = "labelGenreWert";
            labelGenreWert.Size = new Size(110, 15);
            labelGenreWert.TabIndex = 14;
            labelGenreWert.Text = "Unbekanntes Genre";
            // 
            // labelGenre
            // 
            labelGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(38, 232);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(41, 15);
            labelGenre.TabIndex = 13;
            labelGenre.Text = "Genre:";
            // 
            // buttonLabelDetail
            // 
            buttonLabelDetail.Location = new Point(590, 328);
            buttonLabelDetail.Name = "buttonLabelDetail";
            buttonLabelDetail.Size = new Size(160, 46);
            buttonLabelDetail.TabIndex = 12;
            buttonLabelDetail.Text = "Label Detail";
            buttonLabelDetail.UseVisualStyleBackColor = true;
            buttonLabelDetail.Click += buttonLabelDetail_Click;
            // 
            // buttonArtistAnzeigen
            // 
            buttonArtistAnzeigen.Location = new Point(314, 328);
            buttonArtistAnzeigen.Name = "buttonArtistAnzeigen";
            buttonArtistAnzeigen.Size = new Size(160, 46);
            buttonArtistAnzeigen.TabIndex = 11;
            buttonArtistAnzeigen.Text = "Artist Detail";
            buttonArtistAnzeigen.UseVisualStyleBackColor = true;
            buttonArtistAnzeigen.Click += buttonArtistAnzeigen_Click;
            // 
            // buttonAlbumAnzeigen
            // 
            buttonAlbumAnzeigen.Location = new Point(38, 328);
            buttonAlbumAnzeigen.Name = "buttonAlbumAnzeigen";
            buttonAlbumAnzeigen.Size = new Size(160, 46);
            buttonAlbumAnzeigen.TabIndex = 10;
            buttonAlbumAnzeigen.Text = "Album Detail";
            buttonAlbumAnzeigen.UseVisualStyleBackColor = true;
            buttonAlbumAnzeigen.Click += buttonAlbumAnzeigen_Click;
            // 
            // labelFormatWert
            // 
            labelFormatWert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFormatWert.AutoSize = true;
            labelFormatWert.Location = new Point(128, 288);
            labelFormatWert.Name = "labelFormatWert";
            labelFormatWert.Size = new Size(105, 15);
            labelFormatWert.TabIndex = 9;
            labelFormatWert.Text = "Ungültiges Format";
            // 
            // labelLabelWert
            // 
            labelLabelWert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLabelWert.AutoSize = true;
            labelLabelWert.Location = new Point(128, 176);
            labelLabelWert.Name = "labelLabelWert";
            labelLabelWert.Size = new Size(74, 15);
            labelLabelWert.TabIndex = 8;
            labelLabelWert.Text = "Independent";
            // 
            // comboBoxAlben
            // 
            comboBoxAlben.FormattingEnabled = true;
            comboBoxAlben.Location = new Point(128, 117);
            comboBoxAlben.Name = "comboBoxAlben";
            comboBoxAlben.Size = new Size(114, 23);
            comboBoxAlben.TabIndex = 7;
            comboBoxAlben.SelectedIndexChanged += comboBoxAlben_SelectedIndexChanged;
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(128, 61);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(114, 23);
            comboBoxArtist.TabIndex = 6;
            comboBoxArtist.SelectedIndexChanged += comboBoxArtist_SelectedIndexChanged;
            // 
            // labelLabel
            // 
            labelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLabel.AutoSize = true;
            labelLabel.Location = new Point(38, 176);
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new Size(38, 15);
            labelLabel.TabIndex = 5;
            labelLabel.Text = "Label:";
            // 
            // labelFormat
            // 
            labelFormat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFormat.AutoSize = true;
            labelFormat.Location = new Point(38, 288);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(48, 15);
            labelFormat.TabIndex = 4;
            labelFormat.Text = "Format:";
            // 
            // dataGridViewAlbumTrackList
            // 
            dataGridViewAlbumTrackList.AllowUserToAddRows = false;
            dataGridViewAlbumTrackList.AllowUserToDeleteRows = false;
            dataGridViewAlbumTrackList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbumTrackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbumTrackList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAlbumTrackList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbumTrackList.Columns.AddRange(new DataGridViewColumn[] { songNr, songTitel, songDauer, songFeat });
            dataGridViewAlbumTrackList.Location = new Point(294, 64);
            dataGridViewAlbumTrackList.MultiSelect = false;
            dataGridViewAlbumTrackList.Name = "dataGridViewAlbumTrackList";
            dataGridViewAlbumTrackList.ReadOnly = true;
            dataGridViewAlbumTrackList.Size = new Size(591, 244);
            dataGridViewAlbumTrackList.TabIndex = 3;
            dataGridViewAlbumTrackList.SelectionChanged += dataGridViewAlbumTrackList_SelectionChanged;
            // 
            // songNr
            // 
            songNr.HeaderText = "Nr.";
            songNr.Name = "songNr";
            songNr.ReadOnly = true;
            // 
            // songTitel
            // 
            songTitel.HeaderText = "Titel";
            songTitel.Name = "songTitel";
            songTitel.ReadOnly = true;
            // 
            // songDauer
            // 
            songDauer.HeaderText = "Laenge";
            songDauer.Name = "songDauer";
            songDauer.ReadOnly = true;
            // 
            // songFeat
            // 
            songFeat.HeaderText = "Artist/s";
            songFeat.Name = "songFeat";
            songFeat.ReadOnly = true;
            // 
            // labelSongs
            // 
            labelSongs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSongs.AutoSize = true;
            labelSongs.Location = new Point(281, 38);
            labelSongs.Name = "labelSongs";
            labelSongs.Size = new Size(42, 15);
            labelSongs.TabIndex = 2;
            labelSongs.Text = "Songs:";
            // 
            // labelAlben
            // 
            labelAlben.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlben.AutoSize = true;
            labelAlben.Location = new Point(38, 120);
            labelAlben.Name = "labelAlben";
            labelAlben.Size = new Size(46, 15);
            labelAlben.TabIndex = 1;
            labelAlben.Text = "Album:";
            // 
            // labelArtist
            // 
            labelArtist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(38, 64);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(38, 15);
            labelArtist.TabIndex = 0;
            labelArtist.Text = "Artist:";
            // 
            // tabPageAlbumDetail
            // 
            tabPageAlbumDetail.Controls.Add(textBoxAlbumInfo);
            tabPageAlbumDetail.Controls.Add(labelAlbumGenre);
            tabPageAlbumDetail.Controls.Add(dataGridViewAlbumSongList);
            tabPageAlbumDetail.Controls.Add(labelAlbumAlbum);
            tabPageAlbumDetail.Controls.Add(pictureBoxAlbum);
            tabPageAlbumDetail.Controls.Add(labelAlbumArtist);
            tabPageAlbumDetail.Location = new Point(4, 24);
            tabPageAlbumDetail.Name = "tabPageAlbumDetail";
            tabPageAlbumDetail.Padding = new Padding(3);
            tabPageAlbumDetail.Size = new Size(891, 665);
            tabPageAlbumDetail.TabIndex = 1;
            tabPageAlbumDetail.Text = "Album";
            tabPageAlbumDetail.UseVisualStyleBackColor = true;
            // 
            // textBoxAlbumInfo
            // 
            textBoxAlbumInfo.BackColor = SystemColors.Control;
            textBoxAlbumInfo.Location = new Point(331, 93);
            textBoxAlbumInfo.Multiline = true;
            textBoxAlbumInfo.Name = "textBoxAlbumInfo";
            textBoxAlbumInfo.ReadOnly = true;
            textBoxAlbumInfo.Size = new Size(385, 102);
            textBoxAlbumInfo.TabIndex = 5;
            // 
            // labelAlbumGenre
            // 
            labelAlbumGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlbumGenre.AutoSize = true;
            labelAlbumGenre.Font = new Font("Segoe UI", 9F);
            labelAlbumGenre.Location = new Point(56, 96);
            labelAlbumGenre.Name = "labelAlbumGenre";
            labelAlbumGenre.Size = new Size(110, 15);
            labelAlbumGenre.TabIndex = 4;
            labelAlbumGenre.Text = "Unbekanntes Genre";
            // 
            // dataGridViewAlbumSongList
            // 
            dataGridViewAlbumSongList.AllowUserToAddRows = false;
            dataGridViewAlbumSongList.AllowUserToDeleteRows = false;
            dataGridViewAlbumSongList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbumSongList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbumSongList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAlbumSongList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbumSongList.Columns.AddRange(new DataGridViewColumn[] { albumSongNummer, albumSongTitel, albumSongDauer, albumSongBPM, albumSongFormat });
            dataGridViewAlbumSongList.Location = new Point(291, 217);
            dataGridViewAlbumSongList.Name = "dataGridViewAlbumSongList";
            dataGridViewAlbumSongList.Size = new Size(583, 277);
            dataGridViewAlbumSongList.TabIndex = 3;
            // 
            // albumSongNummer
            // 
            albumSongNummer.HeaderText = "Nr.";
            albumSongNummer.Name = "albumSongNummer";
            albumSongNummer.ReadOnly = true;
            // 
            // albumSongTitel
            // 
            albumSongTitel.HeaderText = "Titel";
            albumSongTitel.Name = "albumSongTitel";
            albumSongTitel.ReadOnly = true;
            // 
            // albumSongDauer
            // 
            albumSongDauer.HeaderText = "Dauer:";
            albumSongDauer.Name = "albumSongDauer";
            albumSongDauer.ReadOnly = true;
            // 
            // albumSongBPM
            // 
            albumSongBPM.HeaderText = "BPM";
            albumSongBPM.Name = "albumSongBPM";
            albumSongBPM.ReadOnly = true;
            // 
            // albumSongFormat
            // 
            albumSongFormat.HeaderText = "Format";
            albumSongFormat.Name = "albumSongFormat";
            albumSongFormat.ReadOnly = true;
            // 
            // labelAlbumAlbum
            // 
            labelAlbumAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlbumAlbum.AutoSize = true;
            labelAlbumAlbum.Font = new Font("Segoe UI", 27F);
            labelAlbumAlbum.Location = new Point(6, 7);
            labelAlbumAlbum.Name = "labelAlbumAlbum";
            labelAlbumAlbum.Size = new Size(341, 48);
            labelAlbumAlbum.TabIndex = 2;
            labelAlbumAlbum.Text = "Unbekanntes Album";
            // 
            // pictureBoxAlbum
            // 
            pictureBoxAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAlbum.Location = new Point(6, 217);
            pictureBoxAlbum.Name = "pictureBoxAlbum";
            pictureBoxAlbum.Size = new Size(270, 216);
            pictureBoxAlbum.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlbum.TabIndex = 1;
            pictureBoxAlbum.TabStop = false;
            pictureBoxAlbum.WaitOnLoad = true;
            // 
            // labelAlbumArtist
            // 
            labelAlbumArtist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlbumArtist.AutoSize = true;
            labelAlbumArtist.Font = new Font("Segoe UI", 18F);
            labelAlbumArtist.Location = new Point(35, 55);
            labelAlbumArtist.Name = "labelAlbumArtist";
            labelAlbumArtist.Size = new Size(214, 32);
            labelAlbumArtist.TabIndex = 0;
            labelAlbumArtist.Text = "Unbekannter Artist";
            // 
            // tabPageArtistDetail
            // 
            tabPageArtistDetail.Controls.Add(textBoxArtistInfo);
            tabPageArtistDetail.Controls.Add(pictureBoxArtist);
            tabPageArtistDetail.Controls.Add(labelArtistArtist);
            tabPageArtistDetail.Location = new Point(4, 24);
            tabPageArtistDetail.Name = "tabPageArtistDetail";
            tabPageArtistDetail.Padding = new Padding(3);
            tabPageArtistDetail.Size = new Size(891, 665);
            tabPageArtistDetail.TabIndex = 2;
            tabPageArtistDetail.Text = "Artist";
            tabPageArtistDetail.UseVisualStyleBackColor = true;
            // 
            // textBoxArtistInfo
            // 
            textBoxArtistInfo.Location = new Point(88, 147);
            textBoxArtistInfo.Multiline = true;
            textBoxArtistInfo.Name = "textBoxArtistInfo";
            textBoxArtistInfo.ReadOnly = true;
            textBoxArtistInfo.Size = new Size(332, 191);
            textBoxArtistInfo.TabIndex = 2;
            // 
            // pictureBoxArtist
            // 
            pictureBoxArtist.Location = new Point(435, 48);
            pictureBoxArtist.Name = "pictureBoxArtist";
            pictureBoxArtist.Size = new Size(382, 416);
            pictureBoxArtist.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxArtist.TabIndex = 1;
            pictureBoxArtist.TabStop = false;
            // 
            // labelArtistArtist
            // 
            labelArtistArtist.AutoSize = true;
            labelArtistArtist.Font = new Font("Segoe UI", 27F);
            labelArtistArtist.Location = new Point(88, 48);
            labelArtistArtist.Name = "labelArtistArtist";
            labelArtistArtist.Size = new Size(115, 48);
            labelArtistArtist.TabIndex = 0;
            labelArtistArtist.Text = "label1";
            // 
            // tabPageLabelDetail
            // 
            tabPageLabelDetail.Controls.Add(textBoxLabelInfo);
            tabPageLabelDetail.Controls.Add(labelLabelLabel);
            tabPageLabelDetail.Location = new Point(4, 24);
            tabPageLabelDetail.Name = "tabPageLabelDetail";
            tabPageLabelDetail.Padding = new Padding(3);
            tabPageLabelDetail.Size = new Size(891, 665);
            tabPageLabelDetail.TabIndex = 3;
            tabPageLabelDetail.Text = "Label";
            tabPageLabelDetail.UseVisualStyleBackColor = true;
            // 
            // textBoxLabelInfo
            // 
            textBoxLabelInfo.Location = new Point(25, 116);
            textBoxLabelInfo.Multiline = true;
            textBoxLabelInfo.Name = "textBoxLabelInfo";
            textBoxLabelInfo.ReadOnly = true;
            textBoxLabelInfo.Size = new Size(427, 214);
            textBoxLabelInfo.TabIndex = 1;
            // 
            // labelLabelLabel
            // 
            labelLabelLabel.AutoSize = true;
            labelLabelLabel.Font = new Font("Segoe UI", 27F);
            labelLabelLabel.Location = new Point(25, 20);
            labelLabelLabel.Name = "labelLabelLabel";
            labelLabelLabel.Size = new Size(115, 48);
            labelLabelLabel.TabIndex = 0;
            labelLabelLabel.Text = "label1";
            // 
            // buttonNewArtist
            // 
            buttonNewArtist.Location = new Point(38, 422);
            buttonNewArtist.Name = "buttonNewArtist";
            buttonNewArtist.Size = new Size(160, 46);
            buttonNewArtist.TabIndex = 15;
            buttonNewArtist.Text = "Neuer Artist";
            buttonNewArtist.UseVisualStyleBackColor = true;
            // 
            // StreamDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 717);
            Controls.Add(tabControlOverview);
            Name = "StreamDB";
            Text = "Form1";
            tabControlOverview.ResumeLayout(false);
            tabPageOverview.ResumeLayout(false);
            tabPageOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbumTrackList).EndInit();
            tabPageAlbumDetail.ResumeLayout(false);
            tabPageAlbumDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbumSongList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).EndInit();
            tabPageArtistDetail.ResumeLayout(false);
            tabPageArtistDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtist).EndInit();
            tabPageLabelDetail.ResumeLayout(false);
            tabPageLabelDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlOverview;
        private TabPage tabPageOverview;
        private TabPage tabPageAlbumDetail;
        private System.Windows.Forms.Label labelSongs;
        private System.Windows.Forms.Label labelAlben;
        private System.Windows.Forms.Label labelArtist;
        private DataGridView dataGridViewAlbumTrackList;
        private ComboBox comboBoxArtist;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label labelFormat;
        private DataGridViewTextBoxColumn songNr;
        private DataGridViewTextBoxColumn songTitel;
        private DataGridViewTextBoxColumn songDauer;
        private DataGridViewTextBoxColumn songFeat;
        private System.Windows.Forms.Label labelLabelWert;
        private ComboBox comboBoxAlben;
        private Button buttonArtistAnzeigen;
        private Button buttonAlbumAnzeigen;
        private System.Windows.Forms.Label labelFormatWert;
        private Button buttonLabelDetail;
        private TabPage tabPageArtistDetail;
        private TabPage tabPageLabelDetail;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelGenreWert;
        private System.Windows.Forms.Label labelAlbumArtist;
        private DataGridView dataGridViewAlbumSongList;
        private System.Windows.Forms.Label labelAlbumAlbum;
        private PictureBox pictureBoxAlbum;
        private DataGridViewTextBoxColumn albumSongNummer;
        private DataGridViewTextBoxColumn albumSongTitel;
        private DataGridViewTextBoxColumn albumSongDauer;
        private DataGridViewTextBoxColumn albumSongBPM;
        private DataGridViewTextBoxColumn albumSongFormat;
        private System.Windows.Forms.Label labelAlbumGenre;
        private TextBox textBoxAlbumInfo;
        private TextBox textBoxArtistInfo;
        private PictureBox pictureBoxArtist;
        private System.Windows.Forms.Label labelArtistArtist;
        private System.Windows.Forms.Label labelLabelLabel;
        private TextBox textBoxLabelInfo;
        private Button buttonNewArtist;
    }
}
