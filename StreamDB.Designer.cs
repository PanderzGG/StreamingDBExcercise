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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tabControlOverview = new TabControl();
            tabPageOverview = new TabPage();
            panel1 = new Panel();
            buttonArtistAnzeigen = new Button();
            buttonNewAlbum = new Button();
            buttonAlbumAnzeigen = new Button();
            buttonNewArtist = new Button();
            buttonLabelDetail = new Button();
            labelGenreWert = new System.Windows.Forms.Label();
            labelGenre = new System.Windows.Forms.Label();
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
            tabControlOverview.SuspendLayout();
            tabPageOverview.SuspendLayout();
            panel1.SuspendLayout();
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
            tabPageOverview.BackColor = Color.FromArgb(40, 43, 48);
            tabPageOverview.Controls.Add(panel1);
            tabPageOverview.Controls.Add(labelGenreWert);
            tabPageOverview.Controls.Add(labelGenre);
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
            tabPageOverview.ForeColor = Color.Black;
            tabPageOverview.Location = new Point(4, 24);
            tabPageOverview.Name = "tabPageOverview";
            tabPageOverview.Padding = new Padding(3);
            tabPageOverview.Size = new Size(891, 665);
            tabPageOverview.TabIndex = 0;
            tabPageOverview.Text = "Übersicht";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 57, 62);
            panel1.Controls.Add(buttonArtistAnzeigen);
            panel1.Controls.Add(buttonNewAlbum);
            panel1.Controls.Add(buttonAlbumAnzeigen);
            panel1.Controls.Add(buttonNewArtist);
            panel1.Controls.Add(buttonLabelDetail);
            panel1.Location = new Point(-4, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 184);
            panel1.TabIndex = 17;
            // 
            // buttonArtistAnzeigen
            // 
            buttonArtistAnzeigen.BackColor = Color.FromArgb(40, 43, 48);
            buttonArtistAnzeigen.FlatStyle = FlatStyle.System;
            buttonArtistAnzeigen.ForeColor = Color.White;
            buttonArtistAnzeigen.Location = new Point(42, 3);
            buttonArtistAnzeigen.Name = "buttonArtistAnzeigen";
            buttonArtistAnzeigen.Size = new Size(160, 46);
            buttonArtistAnzeigen.TabIndex = 11;
            buttonArtistAnzeigen.Text = "Artist Detail";
            buttonArtistAnzeigen.UseVisualStyleBackColor = false;
            buttonArtistAnzeigen.Click += buttonArtistAnzeigen_Click;
            // 
            // buttonNewAlbum
            // 
            buttonNewAlbum.BackColor = Color.FromArgb(114, 137, 218);
            buttonNewAlbum.FlatStyle = FlatStyle.System;
            buttonNewAlbum.ForeColor = Color.White;
            buttonNewAlbum.Location = new Point(703, 102);
            buttonNewAlbum.Name = "buttonNewAlbum";
            buttonNewAlbum.Size = new Size(160, 46);
            buttonNewAlbum.TabIndex = 16;
            buttonNewAlbum.Text = "Neues Album";
            buttonNewAlbum.UseVisualStyleBackColor = false;
            buttonNewAlbum.Click += buttonNewAlbum_Click;
            // 
            // buttonAlbumAnzeigen
            // 
            buttonAlbumAnzeigen.BackColor = Color.FromArgb(40, 43, 48);
            buttonAlbumAnzeigen.FlatStyle = FlatStyle.System;
            buttonAlbumAnzeigen.ForeColor = Color.White;
            buttonAlbumAnzeigen.Location = new Point(42, 69);
            buttonAlbumAnzeigen.Name = "buttonAlbumAnzeigen";
            buttonAlbumAnzeigen.Size = new Size(160, 46);
            buttonAlbumAnzeigen.TabIndex = 10;
            buttonAlbumAnzeigen.Text = "Album Detail";
            buttonAlbumAnzeigen.UseVisualStyleBackColor = false;
            buttonAlbumAnzeigen.Click += buttonAlbumAnzeigen_Click;
            // 
            // buttonNewArtist
            // 
            buttonNewArtist.BackColor = Color.FromArgb(114, 137, 218);
            buttonNewArtist.FlatStyle = FlatStyle.System;
            buttonNewArtist.ForeColor = Color.White;
            buttonNewArtist.Location = new Point(703, 50);
            buttonNewArtist.Name = "buttonNewArtist";
            buttonNewArtist.Size = new Size(160, 46);
            buttonNewArtist.TabIndex = 15;
            buttonNewArtist.Text = "Neuer Artist";
            buttonNewArtist.UseVisualStyleBackColor = false;
            buttonNewArtist.Click += buttonNewArtist_Click;
            // 
            // buttonLabelDetail
            // 
            buttonLabelDetail.BackColor = Color.FromArgb(40, 43, 48);
            buttonLabelDetail.FlatStyle = FlatStyle.System;
            buttonLabelDetail.ForeColor = Color.White;
            buttonLabelDetail.Location = new Point(42, 135);
            buttonLabelDetail.Name = "buttonLabelDetail";
            buttonLabelDetail.Size = new Size(160, 46);
            buttonLabelDetail.TabIndex = 12;
            buttonLabelDetail.Text = "Label Detail";
            buttonLabelDetail.UseVisualStyleBackColor = false;
            buttonLabelDetail.Click += buttonLabelDetail_Click;
            // 
            // labelGenreWert
            // 
            labelGenreWert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGenreWert.AutoSize = true;
            labelGenreWert.ForeColor = Color.White;
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
            labelGenre.ForeColor = Color.White;
            labelGenre.Location = new Point(38, 232);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(41, 15);
            labelGenre.TabIndex = 13;
            labelGenre.Text = "Genre:";
            // 
            // labelFormatWert
            // 
            labelFormatWert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFormatWert.AutoSize = true;
            labelFormatWert.ForeColor = Color.White;
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
            labelLabelWert.ForeColor = Color.White;
            labelLabelWert.Location = new Point(128, 176);
            labelLabelWert.Name = "labelLabelWert";
            labelLabelWert.Size = new Size(74, 15);
            labelLabelWert.TabIndex = 8;
            labelLabelWert.Text = "Independent";
            // 
            // comboBoxAlben
            // 
            comboBoxAlben.BackColor = Color.FromArgb(54, 57, 62);
            comboBoxAlben.FlatStyle = FlatStyle.Flat;
            comboBoxAlben.ForeColor = Color.White;
            comboBoxAlben.FormattingEnabled = true;
            comboBoxAlben.Location = new Point(128, 117);
            comboBoxAlben.Name = "comboBoxAlben";
            comboBoxAlben.Size = new Size(114, 23);
            comboBoxAlben.TabIndex = 7;
            comboBoxAlben.SelectedIndexChanged += comboBoxAlben_SelectedIndexChanged;
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.BackColor = Color.FromArgb(54, 57, 62);
            comboBoxArtist.FlatStyle = FlatStyle.Flat;
            comboBoxArtist.ForeColor = Color.White;
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
            labelLabel.ForeColor = Color.White;
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
            labelFormat.ForeColor = Color.White;
            labelFormat.Location = new Point(38, 288);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(48, 15);
            labelFormat.TabIndex = 4;
            labelFormat.Text = "Format:";
            // 
            // dataGridViewAlbumTrackList
            // 
            dataGridViewAlbumTrackList.AllowDrop = true;
            dataGridViewAlbumTrackList.AllowUserToAddRows = false;
            dataGridViewAlbumTrackList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewAlbumTrackList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlbumTrackList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbumTrackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbumTrackList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAlbumTrackList.BackgroundColor = Color.FromArgb(54, 57, 62);
            dataGridViewAlbumTrackList.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 43, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAlbumTrackList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAlbumTrackList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbumTrackList.Columns.AddRange(new DataGridViewColumn[] { songNr, songTitel, songDauer, songFeat });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewAlbumTrackList.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAlbumTrackList.Enabled = false;
            dataGridViewAlbumTrackList.GridColor = Color.FromArgb(30, 33, 36);
            dataGridViewAlbumTrackList.Location = new Point(281, 64);
            dataGridViewAlbumTrackList.MultiSelect = false;
            dataGridViewAlbumTrackList.Name = "dataGridViewAlbumTrackList";
            dataGridViewAlbumTrackList.ReadOnly = true;
            dataGridViewAlbumTrackList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 43, 48);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewAlbumTrackList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAlbumTrackList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            labelSongs.ForeColor = Color.White;
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
            labelAlben.ForeColor = Color.White;
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
            labelArtist.ForeColor = Color.White;
            labelArtist.Location = new Point(38, 64);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(38, 15);
            labelArtist.TabIndex = 0;
            labelArtist.Text = "Artist:";
            // 
            // tabPageAlbumDetail
            // 
            tabPageAlbumDetail.BackColor = Color.FromArgb(40, 43, 48);
            tabPageAlbumDetail.Controls.Add(labelAlbumGenre);
            tabPageAlbumDetail.Controls.Add(dataGridViewAlbumSongList);
            tabPageAlbumDetail.Controls.Add(labelAlbumAlbum);
            tabPageAlbumDetail.Controls.Add(pictureBoxAlbum);
            tabPageAlbumDetail.Controls.Add(labelAlbumArtist);
            tabPageAlbumDetail.Cursor = Cursors.No;
            tabPageAlbumDetail.Location = new Point(4, 24);
            tabPageAlbumDetail.Name = "tabPageAlbumDetail";
            tabPageAlbumDetail.Padding = new Padding(3);
            tabPageAlbumDetail.Size = new Size(891, 665);
            tabPageAlbumDetail.TabIndex = 1;
            tabPageAlbumDetail.Text = "Album";
            // 
            // labelAlbumGenre
            // 
            labelAlbumGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlbumGenre.AutoSize = true;
            labelAlbumGenre.FlatStyle = FlatStyle.Flat;
            labelAlbumGenre.Font = new Font("Segoe UI", 9F);
            labelAlbumGenre.ForeColor = Color.White;
            labelAlbumGenre.Location = new Point(127, 141);
            labelAlbumGenre.Name = "labelAlbumGenre";
            labelAlbumGenre.Size = new Size(110, 15);
            labelAlbumGenre.TabIndex = 4;
            labelAlbumGenre.Text = "Unbekanntes Genre";
            // 
            // dataGridViewAlbumSongList
            // 
            dataGridViewAlbumSongList.AllowUserToAddRows = false;
            dataGridViewAlbumSongList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 33, 36);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewAlbumSongList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAlbumSongList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbumSongList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbumSongList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAlbumSongList.BackgroundColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(40, 43, 48);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewAlbumSongList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewAlbumSongList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbumSongList.Columns.AddRange(new DataGridViewColumn[] { albumSongNummer, albumSongTitel, albumSongDauer, albumSongBPM, albumSongFormat });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewAlbumSongList.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewAlbumSongList.GridColor = Color.FromArgb(30, 33, 36);
            dataGridViewAlbumSongList.Location = new Point(68, 280);
            dataGridViewAlbumSongList.MultiSelect = false;
            dataGridViewAlbumSongList.Name = "dataGridViewAlbumSongList";
            dataGridViewAlbumSongList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(30, 33, 36);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewAlbumSongList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewAlbumSongList.RowHeadersVisible = false;
            dataGridViewAlbumSongList.Size = new Size(756, 359);
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
            labelAlbumAlbum.FlatStyle = FlatStyle.Flat;
            labelAlbumAlbum.Font = new Font("Segoe UI", 27F);
            labelAlbumAlbum.ForeColor = Color.White;
            labelAlbumAlbum.Location = new Point(116, 59);
            labelAlbumAlbum.Name = "labelAlbumAlbum";
            labelAlbumAlbum.Size = new Size(341, 48);
            labelAlbumAlbum.TabIndex = 2;
            labelAlbumAlbum.Text = "Unbekanntes Album";
            // 
            // pictureBoxAlbum
            // 
            pictureBoxAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAlbum.Location = new Point(535, 15);
            pictureBoxAlbum.Name = "pictureBoxAlbum";
            pictureBoxAlbum.Size = new Size(289, 249);
            pictureBoxAlbum.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlbum.TabIndex = 1;
            pictureBoxAlbum.TabStop = false;
            pictureBoxAlbum.WaitOnLoad = true;
            // 
            // labelAlbumArtist
            // 
            labelAlbumArtist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlbumArtist.AutoSize = true;
            labelAlbumArtist.FlatStyle = FlatStyle.Flat;
            labelAlbumArtist.Font = new Font("Segoe UI", 18F);
            labelAlbumArtist.ForeColor = Color.White;
            labelAlbumArtist.Location = new Point(122, 105);
            labelAlbumArtist.Name = "labelAlbumArtist";
            labelAlbumArtist.Size = new Size(214, 32);
            labelAlbumArtist.TabIndex = 0;
            labelAlbumArtist.Text = "Unbekannter Artist";
            // 
            // tabPageArtistDetail
            // 
            tabPageArtistDetail.BackColor = Color.FromArgb(40, 43, 48);
            tabPageArtistDetail.Controls.Add(textBoxArtistInfo);
            tabPageArtistDetail.Controls.Add(pictureBoxArtist);
            tabPageArtistDetail.Controls.Add(labelArtistArtist);
            tabPageArtistDetail.Location = new Point(4, 24);
            tabPageArtistDetail.Name = "tabPageArtistDetail";
            tabPageArtistDetail.Padding = new Padding(3);
            tabPageArtistDetail.Size = new Size(891, 665);
            tabPageArtistDetail.TabIndex = 2;
            tabPageArtistDetail.Text = "Artist";
            // 
            // textBoxArtistInfo
            // 
            textBoxArtistInfo.BackColor = Color.FromArgb(54, 57, 62);
            textBoxArtistInfo.ForeColor = Color.White;
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
            labelArtistArtist.ForeColor = Color.White;
            labelArtistArtist.Location = new Point(88, 48);
            labelArtistArtist.Name = "labelArtistArtist";
            labelArtistArtist.Size = new Size(115, 48);
            labelArtistArtist.TabIndex = 0;
            labelArtistArtist.Text = "label1";
            // 
            // tabPageLabelDetail
            // 
            tabPageLabelDetail.BackColor = Color.FromArgb(40, 43, 48);
            tabPageLabelDetail.Controls.Add(textBoxLabelInfo);
            tabPageLabelDetail.Controls.Add(labelLabelLabel);
            tabPageLabelDetail.Location = new Point(4, 24);
            tabPageLabelDetail.Name = "tabPageLabelDetail";
            tabPageLabelDetail.Padding = new Padding(3);
            tabPageLabelDetail.Size = new Size(891, 665);
            tabPageLabelDetail.TabIndex = 3;
            tabPageLabelDetail.Text = "Label";
            // 
            // textBoxLabelInfo
            // 
            textBoxLabelInfo.BackColor = Color.FromArgb(54, 57, 62);
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
            labelLabelLabel.ForeColor = Color.White;
            labelLabelLabel.Location = new Point(25, 20);
            labelLabelLabel.Name = "labelLabelLabel";
            labelLabelLabel.Size = new Size(115, 48);
            labelLabelLabel.TabIndex = 0;
            labelLabelLabel.Text = "label1";
            // 
            // StreamDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(923, 717);
            Controls.Add(tabControlOverview);
            Name = "StreamDB";
            Text = "Form1";
            tabControlOverview.ResumeLayout(false);
            tabPageOverview.ResumeLayout(false);
            tabPageOverview.PerformLayout();
            panel1.ResumeLayout(false);
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
        private TextBox textBoxArtistInfo;
        private PictureBox pictureBoxArtist;
        private System.Windows.Forms.Label labelArtistArtist;
        private System.Windows.Forms.Label labelLabelLabel;
        private TextBox textBoxLabelInfo;
        private Button buttonNewArtist;
        private Button buttonNewAlbum;
        private Panel panel1;
    }
}
