namespace StreamingDB
{
    public partial class StreamDB : Form
    {

        private static bool detail;
        private static bool justSwitched;

        Datenbank db = new Datenbank();
        XML xml = new XML("Album.xml");

        List<Label> labels = new List<Label>();
        List<Artist> artists = new List<Artist>();
        List<Genre> genres = new List<Genre>();
        List<Album> alben = new List<Album>();
        List<Song> songs = new List<Song>();
        List<Featuring> featurings = new List<Featuring>();
        List<SongData> songData = new List<SongData>();

        public StreamDB()
        {
            InitializeComponent();
            onLoadLists();
            onLoadComboBox();
            onLoadHideTabs();
        }


        #region onLoad
        private void onLoadLists()
        {
            artists = db.getArtists();
            genres = db.getGenre();
            alben = db.getAlben();
            songs = db.getSongs();
            featurings = db.getFeaturing();
            songData = db.getSongData();
            labels = db.getLabels();

            if (comboBoxArtist.SelectedIndex == -1)
            {
                comboBoxAlben.Enabled = false;
            }
        }

        private void onLoadComboBox()
        {
            comboBoxArtist.Items.Clear();
            try
            {
                foreach (Artist ar in artists)
                {
                    comboBoxArtist.Items.Add(ar.ArtistName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("onLoadComboBox " + ex.Message);
            }
            finally
            {

            }

        }

        private void onLoadHideTabs()
        {
            tabControlOverview.TabPages.Remove(tabPageAlbumDetail);
            tabControlOverview.TabPages.Remove(tabPageArtistDetail);
            tabControlOverview.TabPages.Remove(tabPageLabelDetail);

            detail = false;
            justSwitched = false;
        }
        #endregion

        #region Overview Methoden


        private void comboBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxAlben.Items.Clear();
            comboBoxAlben.Text = "";

            if (comboBoxArtist.SelectedIndex != -1)
            {
                comboBoxAlben.Enabled = true;
            }

            // Alben ComboBox füllen
            try
            {

                foreach (Album album in alben)
                {
                    int? check = artists.Find(x => x.ArtistID == album.ArtistID).ArtistID;

                    if (check == artists[comboBoxArtist.SelectedIndex].ArtistID)
                    {
                        comboBoxAlben.Items.Add(album.AlbumName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("comboBoxArtist_SelectedIndexChanged " + ex.Message);
            }
        }



        private void comboBoxAlben_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLabelWert.Text = "";
            labelFormatWert.Text = "";
            dataGridViewAlbumTrackList.Rows.Clear();
            try
            {
                if (comboBoxAlben.SelectedIndex != -1)
                {
                    var selectedAlbum = alben.Find(x => x.AlbumName == comboBoxAlben.Text);
                    var label = labels.FirstOrDefault(x => x.LabelID == selectedAlbum.LabelID);

                    labelLabelWert.Text = label?.LabelName ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                int songCount = 0;

                foreach (Song song in songs)
                {
                    var selectedAlbum = alben.Find(x => x.AlbumName == comboBoxAlben.Text).AlbumID;
                    var selectedSongData = songData.Find(x => x.SongID == song.SongID);
                    var selectedFeat = featurings.Find(x => x.SongID == song.SongID);
                    var artist = artists.Find(x => x.ArtistID == selectedFeat.ArtistID);

                    if (comboBoxAlben.SelectedIndex != -1 && song.AlbumID == selectedAlbum)
                    {
                        songCount++;
                        dataGridViewAlbumTrackList.Rows.Add(songCount, song.SongTitel.ToString(), selectedSongData?.SongDauer, artist.ArtistName);
                    }
                }

                songCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewAlbumTrackList_SelectionChanged(object sender, EventArgs e)
        {

            var selectedSong = songs.Find(x => x.SongTitel == dataGridViewAlbumTrackList.CurrentRow.Cells[1].Value.ToString()).SongID;


            var selectedSongData = songData.Find(x => x.SongID == selectedSong);

            // Ermittelt das Genre, indem erneut über den Songtitel gesucht wird und dessen GenreID verwendet wird
            // Schließlich wird dieser Wert in 'selectedGenre' gesichert
            int selectedGenre = genres.Find(x => x.GenreID == songs.Find(x => x.SongTitel == dataGridViewAlbumTrackList.CurrentRow.Cells[1].Value.ToString()).GenreID).GenreID;

            if (dataGridViewAlbumTrackList.CurrentRow != null)
            {
                labelFormatWert.Text = selectedSongData?.SongFormat ?? "";

                // Holt sich den Genre-Namen anhand der ermittelten GenreID aus der 'genres'-Liste
                labelGenreWert.Text = genres.Find(x => x.GenreID == selectedGenre).GenreName;
            }
        }

        private void buttonAlbumAnzeigen_Click(object sender, EventArgs e)
        {
            if (detail == false && comboBoxAlben.SelectedIndex != -1)
            {
                detail = true;
                tabControlOverview.TabPages.Add(tabPageAlbumDetail);
                tabControlOverview.SelectedTab = tabPageAlbumDetail;
            }
        }

        private void buttonArtistAnzeigen_Click(object sender, EventArgs e)
        {
            if (detail == false && comboBoxArtist.SelectedIndex != -1)
            {
                detail = true;
                tabControlOverview.TabPages.Add(tabPageArtistDetail);
                tabControlOverview.SelectedTab = tabPageArtistDetail;
            }
        }

        private void buttonLabelDetail_Click(object sender, EventArgs e)
        {
            if (detail == false && comboBoxAlben.SelectedIndex != -1)
            {
                detail = true;
                tabControlOverview.TabPages.Add(tabPageLabelDetail);
                tabControlOverview.SelectedTab = tabPageLabelDetail;
            }
        }

        #endregion

        private void tabControlOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControlOverview.TabIndex == 0 && detail == true && justSwitched == true)
            {
                onLoadHideTabs();
            }
            else
            {
                justSwitched = true;
            }

            int selectedTabIndex = tabControlOverview.SelectedIndex;

            switch (selectedTabIndex)
            {
                case 0:

                    break;
                case 1:
                    albumAbruf();
                    loadAlbumCover();
                    break;
                case 2:

                    break;
                default:
                    break;
            }
        }


        private void albumAbruf()
        {
            try
            {
                labelAlbumAlbum.Text = comboBoxAlben.Text;
                labelAlbumArtist.Text = comboBoxArtist.Text;
                labelAlbumGenre.Text = labelGenreWert.Text;

                try
                {
                    int trackCount = dataGridViewAlbumTrackList.Rows.Count;

                    for(int i = 0; i < trackCount; i++)
                    {
                        var selectedSong = songs.Find(x => x.SongTitel == dataGridViewAlbumTrackList.Rows[i].Cells[1].Value.ToString()).SongID;
                        var selectedSongData = songData.Find(x => x.SongID == selectedSong);

                        dataGridViewAlbumSongList.Rows.Add(
                            dataGridViewAlbumTrackList.Rows[i].Cells[0].Value,
                            dataGridViewAlbumTrackList.Rows[i].Cells[1].Value,
                            dataGridViewAlbumTrackList.Rows[i].Cells[2].Value,
                            selectedSongData?.SongBPM,
                            selectedSongData?.SongFormat
                            );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadAlbumCover()
        {
            try
            {
                // Altes Bild freigeben
                if (pictureBoxAlbum.Image != null)
                {
                    pictureBoxAlbum.Image.Dispose();
                    pictureBoxAlbum.Image = null;
                }

                // Bildpfad kombinieren
                string imagesDirectory = Path.Combine(Application.StartupPath, "Images");
                string albumCover = alben.Find(x => x.AlbumName == labelAlbumAlbum.Text)?.AlbumCover;

                

                if (string.IsNullOrEmpty(albumCover))
                {
                    MessageBox.Show("Kein Albumcover angegeben.");
                    return;
                }

                string imagePath = Path.Combine(imagesDirectory, albumCover);
                MessageBox.Show(imagePath);

                // Überprüfen, ob die Datei existiert
                if (!File.Exists(imagePath))
                {
                    MessageBox.Show($"Bilddatei nicht gefunden: {imagePath}");
                    return;
                }

                // Neues Bild laden            
                pictureBoxAlbum.Image = Image.FromFile(imagePath);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Das Bildformat ist ungültig oder die Datei ist beschädigt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden des Bildes: {ex.Message}");
            }
        }
    }
}

